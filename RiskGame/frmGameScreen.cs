using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RiskGame
{
    public partial class frmGameScreen : Form
    {
        int pauseShown = 1;
        public static Game Game = frmSetupGame.Game;
        public static Plys Pl2 = frmSetupGame.Player2;
        public static Plys Pl3 = frmSetupGame.Player3;
        string[] allExtras = File.ReadAllLines("regions_extras.conf");
        Region[] regions = new Region[File.ReadLines("regions.conf").Count()];
        bool ignoreCloseness = false;
        bool pauseCooldown = false;
        Random rnd = new Random();

        bool sourceSelected = false;
        bool targetSelected = false;
        Region tempSourceSelection;
        Region tempTargetSelection;
        Region source = new Region();
        Region target = new Region();
        Region activeR = new Region();

        Bitmap actualImage;
        Plys current;

        public frmGameScreen()
        {
            InitializeComponent();
        }

        private void frmGameScreen_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            pnlPause.BringToFront();
            if (!frmLogin.human.DEBUGSkipToGame)
                Application.OpenForms["frmDashboard"].Close();
            int AICount = Game.AICount;
            int OthersCount = Game.OthersCount;
            int playerCount = AICount + OthersCount;
            Game.currentPlayer = 0;
            pnlPause.Location = new Point(-455, 0);
            MSGpnlMessageGroup.Location = new Point(1541, 48);

            Game.calcPlayers();
            new frmPlayerSwapper().Show();

            pnlSource.Location = new Point(3, 775);

            pbBase.BackColor = Color.FromArgb(153, 220, 243);
            if (!frmLogin.human.DEBUGIgnoreAssigned)
            {
                AssignRegions(playerCount + 1);
            }
            //GameStateChanger(3);
        }

        public void ReturnToGameScreen()
        {
            if (Game.currentPlayer == 0)
            {
                current = frmLogin.human;
            }
            else if (Game.currentPlayer == 1)
            {
                current = Pl2;
            }
            else
            {
                current = Pl3;
            }

            switch (Game.state)
            {
                case 0:
                    //Deploy
                    INDICATORpnlDeploy.BackColor = current.accentColour;
                    break;
                case 1:
                    //Attack
                    INDICATORpnlDeploy.BackColor = Color.LightGray;
                    INDICATORpnlAttack.BackColor = current.accentColour;
                    break;
                case 2:
                    //ReEnforce
                    INDICATORpnlDeploy.BackColor = Color.Gray;
                    INDICATORpnlAttack.BackColor = Color.Gray;
                    INDICATORpnlReEnforce.BackColor = current.accentColour;
                    break;
                case 3:
                    //Game is paused
                    break;
                default:
                    //Prevents crashing - Game should never be in a state other than 0,1,2, or 3.
                    break;
            }

            changeTR(current.troopPocket);
        }

        private void AssignRegions(int a)
        {
            string[] allRegionData = File.ReadAllLines("regions.conf");
            for (int i = 0; i < File.ReadLines("regions.conf").Count(); i++)
            {
                regions[i] = new Region();
                regions[i].name = allRegionData[i].Split('~')[0];
                int b = rnd.Next(0, a);
                regions[i].SetController(b);
                regions[i].SetTerritory();
                regions[i].SetPoint(Convert.ToInt32(allRegionData[i].Split('~')[1].Split(',')[0]), Convert.ToInt32(allRegionData[i].Split('~')[1].Split(',')[1]));
                Color colour;
                if (b == 0)
                    colour = (frmLogin.human.accentColour);
                else if (b == 1)
                    colour = (Pl2.accentColour);
                else
                    colour = (Pl3.accentColour);
                regions[i].colour = ColorTranslator.ToHtml(colour);
                FloodFill((Bitmap)pbBase.Image, new Point(regions[i].CentralX, regions[i].CentralY), colour);

                //Extras (Parts of a region that aren't connected by whitespace - e.g. Pacific Islands)
                bool extraChecked = false;
                bool aaa = false;

                for (int g = 0; g < allExtras.Length; g++)
                {
                    aaa = false;
                    ignoreCloseness = false;

                    for (int h = 0; h < allExtras[g].Split('~').Length; h++)
                    {
                        string p = allExtras[g].Split('~')[h];
                        string[] xy = p.Split(',');
                        int x = Convert.ToInt32(xy[0]);
                        int y = Convert.ToInt32(xy[1]);
                        Point pt = new Point(x, y);
                        Bitmap bmp = (Bitmap)pbBase.Image;
                        Color test = bmp.GetPixel(pt.X, pt.Y);
                        if (!aaa && IsClose(test, colour, 400))
                        {
                            aaa = true;
                            ignoreCloseness = true;
                            h = 0;
                        }
                        if (aaa)
                        {
                            FloodFill((Bitmap)pbBase.Image, pt, colour);
                        }
                    }
                }

                //Display Troops Count!
                PictureBox pnl = new PictureBox();
                pnl.Image = Properties.Resources.troopBase;
                pnl.Size = new Size(50, 50);
                //FloodFill((Bitmap)pnl.Image, new Point(regions[i].CentralX, regions[i].CentralY+25), colour);
                pnl.Refresh();
                pnl.SizeMode = PictureBoxSizeMode.Zoom;
                pbBase.Controls.Add(pnl);
                pnl.Location = new Point(regions[i].CentralX - 25, regions[i].CentralY - 25);
                pnl.BackColor = Color.Transparent;
                pnl.Click += new EventHandler(troopDisplay_Click);
                pnl.Name = "pnlREGION_" + regions[i].name;
                pnl.BringToFront();

                Label lb = new Label();
                lb.Text = Convert.ToString(rnd.Next(1, 4));
                regions[i].troopCount = Convert.ToInt32(lb.Text);
                lb.ForeColor = Color.Black;
                pnl.Controls.Add(lb);
                lb.Location = new Point(/*regions[i].CentralX, regions[i].CentralY*/15, 5);
                lb.BackColor = Color.Transparent;
                lb.Font = new Font("Segoe UI", 18, FontStyle.Bold);
                lb.Click += new EventHandler(troopDisplay_Click);
                lb.Name = "lbREGION_" + regions[i].name;
                lb.BringToFront();
            }
            rnd.Next(1, a);
        }

        private void troopDisplay_Click(object sender, EventArgs e)
        {
            Game.Message("You've clicked a troop display!\r\nDon't do that yet please!\r\nTry clicking on the region itself!", MSGpnlMessageGroup, MSGlbMessage);
        }

        private void lbGamePaused_Click(object sender, EventArgs e)
        {

        }
        private void frmGameScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && !pauseCooldown)
            {
                tmrPauseCooldown.Interval = 1000;
                tmrPauseCooldown.Start();
                pauseCooldown = true;
                pauseShown++;
                if (pauseShown % 2 == 0)
                {
                    //Pause
                    actualImage = (Bitmap)pbBase.Image;
                    AnimatePauseScreen(0);
                    //pbBase.Image = Game.MakeGrayscale((Bitmap)pbBase.Image);
                }
                else
                {
                    //Unpause
                    AnimatePauseScreen(1);
                    pbBase.Image = actualImage;
                }
            }

        }

        private void AnimatePauseScreen(int direction)
        {
            int currentState = Game.state;
            int animateSpeed = 10;
            //Default location: -455,0
            //Paused location: 0,0

            if (direction == 0)
            {
                //Pause
                Game.state = 3;
                lbGamePaused.Visible = true;
                int xCurrent = pnlPause.Location.X;
                for (int i = 0; i < (460 / animateSpeed); i++)
                {
                    pnlPause.Location = new Point(xCurrent + (Convert.ToInt32(animateSpeed) * i), 42);
                    pnlPause.Refresh();
                }
            }
            else
            {
                //Unpause
                Game.state = currentState;
                int xCurrent = pnlPause.Location.X;
                for (int i = 0; i < (460 / animateSpeed); i++)
                {
                    pnlPause.Location = new Point(xCurrent - (Convert.ToInt32(animateSpeed) * i), 42);
                    pnlPause.Refresh();
                }
                lbGamePaused.Visible = false;
            }
        }

        private void lbPauseResume_Click(object sender, EventArgs e)
        {
            PauseAction(0);
        }

        private void lbPauseQuit_Click(object sender, EventArgs e)
        {
            PauseAction(4);
        }

        private void pnlPause_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PauseAction(int ID)
        {
            switch (ID)
            {
                case 0:
                    //Resume
                    pauseShown++;
                    AnimatePauseScreen(1);
                    break;
                case 1:
                    //Invite
                    //Idea: Allow the user to substitute in (a) real player(s) in place of (an|both) AI(s).
                    MessageBox.Show("Invite");
                    break;
                case 2:
                    //Overview
                    //Idea: Maybe show the Player Swapping screen without changing who's turn it is, to show the player's current status,
                    //e.g. how many troops they have, how many regions they control, etc., since this was going to be shown here anyway.
                    MessageBox.Show("Overview");
                    break;
                case 3:
                    //Settings
                    MessageBox.Show("Settings");
                    break;
                case 4:
                    //Quit
                    if (MessageBox.Show("Are you sure you want to Quit?\r\n\r\nNone of your progress will be saved!\r\n\r\nClick Yes to confirm, click No to return to the game.", "Are you sure you want to Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        Hide();
                        new frmDashboard().Show();
                    }
                    else
                    {
                        pauseShown++;
                        AnimatePauseScreen(1);
                    }
                    break;
            }
        }
        private void PauseMouseAction(PictureBox pb, Image i)
        {
            pb.Image = i;
        }

        private bool IsClose(Color trg, Color what)
        {
            bool valid = false;

            var rDist = Math.Abs(trg.R - what.R);
            var gDist = Math.Abs(trg.G - what.G);
            var bDist = Math.Abs(trg.B - what.B);

            //Lowering threshold leads to less tolerancy
            if (rDist + gDist + bDist < 140)
            {
                valid = true;
            }

            return valid;
        }
        private bool IsClose(Color trg, Color what, int threshold)
        {
            bool valid = false;

            var rDist = Math.Abs(trg.R - what.R);
            var gDist = Math.Abs(trg.G - what.G);
            var bDist = Math.Abs(trg.B - what.B);

            //Lowering threshold leads to less tolerancy
            if (rDist + gDist + bDist < threshold)
            {
                valid = true;
            }

            return valid;
        }

        //Flood Fill Algorithm
        private void FloodFill(Bitmap bmp, Point pt, Color replaceWith)
        {
            Queue<Point> pixels = new Queue<Point>();
            pixels.Enqueue(pt);

            while (pixels.Count > 0)
            {
                Point a = pixels.Dequeue();
                if (a.X < bmp.Width && a.X > 0 &&
                        a.Y < bmp.Height && a.Y > 0)//make sure we stay within bounds
                {
                    if (IsClose(bmp.GetPixel(a.X, a.Y), Color.White) && bmp.GetPixel(a.X, a.Y) != Color.Black)
                    {
                        bmp.SetPixel(a.X, a.Y, replaceWith);
                        pixels.Enqueue(new Point(a.X - 1, a.Y));
                        pixels.Enqueue(new Point(a.X + 1, a.Y));
                        pixels.Enqueue(new Point(a.X, a.Y - 1));
                        pixels.Enqueue(new Point(a.X, a.Y + 1));
                    }
                }
            }
            pbBase.Refresh(); //refresh our main picture box
            return;
        }
        //Flood Fill Algorithm CUSTOM
        private void FloodFill(Bitmap bmp, Point pt, Color replaceWith, Color original, int threshold)
        {
            Queue<Point> pixels = new Queue<Point>();
            pixels.Enqueue(pt);

            while (pixels.Count > 0)
            {
                Point a = pixels.Dequeue();
                if (a.X < bmp.Width && a.X > 0 &&
                        a.Y < bmp.Height && a.Y > 0)//make sure we stay within bounds
                {
                    if (IsClose(bmp.GetPixel(a.X, a.Y), original, threshold) && bmp.GetPixel(a.X, a.Y) != Color.Black)
                    {
                        bmp.SetPixel(a.X, a.Y, replaceWith);
                        pixels.Enqueue(new Point(a.X - 1, a.Y));
                        pixels.Enqueue(new Point(a.X + 1, a.Y));
                        pixels.Enqueue(new Point(a.X, a.Y - 1));
                        pixels.Enqueue(new Point(a.X, a.Y + 1));
                    }
                }
            }
            pbBase.Refresh(); //refresh our main picture box
            return;
        }

        private void pbBase_MouseDown(object sender, MouseEventArgs e)
        {
            Point mousePosition = new Point(e.X, e.Y);

            Bitmap bmp = (Bitmap)pbBase.Image;
            if (bmp.GetPixel(mousePosition.X, mousePosition.Y) != Color.FromArgb(153, 220, 243))
            {
                if (Game.state == 0)
                {
                    Region deployCandidate = RegionID(mousePosition);
                    //Deploy Mode Active
                    if (deployCandidate.owner == Game.currentPlayer)
                    {
                        activeR = RegionID(mousePosition);
                        troopCountDisplay(mousePosition, current.troopPocket, activeR.name);
                    }
                    else
                    {
                        Game.Message("You have clicked on a region that\r\n is not yours. Please select a \r\nregion that is yours.", MSGpnlMessageGroup, MSGlbMessage);
                    }
                }
                else if (Game.state == 1)
                {
                    //Attack Mode Active
                    if (!sourceSelected)
                    {
                        tempSourceSelection = RegionID(mousePosition);

                        if (tempSourceSelection.owner == Game.currentPlayer)
                        {
                            //Select Source
                            source.name = "";
                            if (tempSourceSelection.name == "" || tempSourceSelection.name == "none")
                            {
                                //Do nothing
                            }
                            else if (tempSourceSelection.troopCount > 1)
                            {
                                sourceSelected = true;
                                source = tempSourceSelection;
                                //Animate source viewer
                                //Required location: 3, 701
                                //Default location: 3, 775
                                int animateSpeed = 2;
                                int yCurrent = pnlSource.Location.Y;
                                for (int i = 0; i < (74 / animateSpeed); i++)
                                {
                                    pnlSource.Location = new Point(3, yCurrent - (Convert.ToInt32(animateSpeed) * i));
                                    pnlSource.Refresh();
                                }

                                lbSourceName.Text = source.name;
                                pnlAttackButton.Visible = true;
                                pnlAttackButton.Enabled = true;
                                btnMoveTroops.Visible = false;
                            }
                            else
                            {
                                Game.Message("You need to have a source\r\nof greater than 1 troops.", MSGpnlMessageGroup, MSGlbMessage);
                            }
                        }
                        else
                        {
                            Game.Message("You have clicked on a region that\r\n is not yours. Please select a \r\nregion that is yours.", MSGpnlMessageGroup, MSGlbMessage);
                        }
                    }
                    else if (!targetSelected)
                    {
                        tempTargetSelection = RegionID(mousePosition);

                        if (tempTargetSelection.owner != Game.currentPlayer && tempTargetSelection.Closeness(source, tempTargetSelection))
                        {
                            //Select Target
                            //target.name = "";
                            if (tempTargetSelection.name == "" || tempTargetSelection.name == "none")
                            {
                                //Do nothing
                            }
                            else
                            {
                                targetSelected = true;
                                target = tempTargetSelection;
                                lbSourceName.Text = source.name + " -> " + target.name;
                                pbSource.Image = Properties.Resources.target;

                                //Draw arrow
                                Graphics g = pbBase.CreateGraphics();
                                Pen p = new Pen(Brushes.Black, 8);
                                p.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                                g.DrawLine(p, source.CentralX, source.CentralY, target.CentralX, target.CentralY);
                            }
                        }
                        else if (tempTargetSelection.owner != Game.currentPlayer)
                        {
                            Game.Message("That region is not close!\r\nPlease select a region that is close.", MSGpnlMessageGroup, MSGlbMessage);
                        }
                        else
                        {
                            Game.Message("You can't invade your own region!\r\nPlease select a region that \r\nis not yours.", MSGpnlMessageGroup, MSGlbMessage);
                        }
                    }

                    else
                    {
                        MessageBox.Show("Invalid Click!");
                    }
                }
                else if (Game.state == 2)
                {
                    // Reinforce Mode
                    btnMoveTroops.Visible = true;
                    if (!sourceSelected)
                    {
                        tempSourceSelection = RegionID(mousePosition);

                        if (tempSourceSelection.owner == Game.currentPlayer)
                        {
                            //Select Source
                            source.name = "";
                            if (tempSourceSelection.name == "" || tempSourceSelection.name == "none")
                            {
                                //Do nothing
                            }
                            else if (tempSourceSelection.troopCount > 1)
                            {
                                sourceSelected = true;
                                source = tempSourceSelection;
                                //Animate source viewer
                                //Required location: 3, 701
                                //Default location: 3, 775
                                int animateSpeed = 2;
                                int yCurrent = pnlSource.Location.Y;
                                for (int i = 0; i < (74 / animateSpeed); i++)
                                {
                                    pnlSource.Location = new Point(3, yCurrent - (Convert.ToInt32(animateSpeed) * i));
                                    pnlSource.Refresh();
                                }

                                lbSourceName.Text = source.name;
                                pnlAttackButton.Visible = false;
                                pnlAttackButton.Enabled = false;
                            }
                            else
                            {
                                Game.Message("You need to have a source\r\nof greater than 1 troops.", MSGpnlMessageGroup, MSGlbMessage);
                            }
                        }
                        else
                        {
                            Game.Message("You have clicked on a region that\r\n is not yours. Please select a \r\nregion that is yours.", MSGpnlMessageGroup, MSGlbMessage);
                        }
                    }
                    else if (!targetSelected)
                    {
                        tempTargetSelection = RegionID(mousePosition);

                        if (tempTargetSelection.owner == Game.currentPlayer)
                        {
                            //Select Target
                            //target.name = "";
                            if (tempTargetSelection.name == "" || tempTargetSelection.name == "none")
                            {
                                //Do nothing
                            }
                            else
                            {
                                targetSelected = true;
                                target = tempTargetSelection;
                                lbSourceName.Text = source.name + " -> " + target.name + "\r\nWarning: 1-3 troops could be lost in transit.";
                                pbSource.Image = Properties.Resources.target;

                                //Draw arrow
                                Graphics g = pbBase.CreateGraphics();
                                Pen p = new Pen(Brushes.Black, 8);
                                p.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                                g.DrawLine(p, source.CentralX, source.CentralY, target.CentralX, target.CentralY);
                            }
                        }
                        else
                        {
                            Game.Message("You can't travel to their region!\r\nPlease select a region that \r\nis yours.", MSGpnlMessageGroup, MSGlbMessage);
                        }
                    }

                    else
                    {
                        MessageBox.Show("Invalid Click!");
                    }
                }

                //DEBUG MODE
                if (frmLogin.human.DEBUGIgnoreAssigned)
                {
                    DEBUGClickMode(new Point(e.X, e.Y));
                }
            }
            else
            {
                MessageBox.Show("Don't click on the ocean!");
            }
        }

        private Region RegionID(Point test)
        {
            Region regionSuggestion = new Region();

            //Step 1: Save the colour of the clicked pixel.
            Bitmap bmp = (Bitmap)pbBase.Image;
            Color pixelColour = bmp.GetPixel(test.X, test.Y);

            //Step 2: Save this colour again, but slightly changed.
            Color lighterPixelColour = ControlPaint.Dark(pixelColour);

            //Step 3: Flood fill using this slightly changed colour.
            FloodFill(bmp, test, lighterPixelColour, pixelColour, 10);

            //Step 4: Compare the points in regions.conf to see which one matches this SLIGHTLY CHANGED colour.
            string[] regionData = File.ReadAllLines("regions.conf");
            for (int i = 0; i < regionData.Length; i++)
            {
                string tempName = regionData[i].Split('~')[0];
                Point tempPoint = new Point(Convert.ToInt32(regionData[i].Split('~')[1].Split(',')[0]), Convert.ToInt32(regionData[i].Split('~')[1].Split(',')[1]));

                //Step 5: If there are no matches, user did not click on a region, sourceSuggestion is "invalid", checked by tempSource.
                //Step 6: If there is a match, save the region's name and ID, change the colour back to the originally saved colour, then return this region information.
                if (bmp.GetPixel(tempPoint.X, tempPoint.Y) == lighterPixelColour)
                {
                    //YES THIS IS A REGION!
                    //Search regions for one with name tempName
                    for (int j = 0; j < regions.Length; j++)
                    {
                        if (regions[j].name == tempName)
                        {
                            regionSuggestion = regions[j];
                        }
                    }
                }
            }

            FloodFill(bmp, test, pixelColour, lighterPixelColour, 10);

            return regionSuggestion;
        }

        private void DEBUGClickMode(Point cursorPos)
        {
            Cursor current = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Clipboard.SetText(string.Format("~" + cursorPos.X + "," + cursorPos.Y));
            Color change = (frmLogin.human.accentColour);
            Bitmap bmp = new Bitmap(pbBase.Image);
            FloodFill((Bitmap)pbBase.Image, cursorPos, change);

            bool extraChecked = false;
            bool aaa = false;

            for (int i = 0; i < allExtras.Length; i++)
            {
                aaa = false;
                ignoreCloseness = false;
                for (int g = 0; g < allExtras[i].Split('~').Length; g++)
                {
                    string p = allExtras[i].Split('~')[g];
                    string[] xy = p.Split(',');
                    int x = Convert.ToInt32(xy[0]);
                    int y = Convert.ToInt32(xy[1]);
                    Point a = new Point(x, y);
                    Color test = bmp.GetPixel(a.X, a.Y);
                    if (!aaa && IsClose(test, change, 400))
                    {
                        aaa = true;
                        ignoreCloseness = true;
                        g = 0;
                    }
                    if (aaa)
                    {
                        FloodFill(bmp, a, change);
                    }
                }
            }

            Cursor.Current = current;
        }
        private Color getRealColour(string htmlCode)
        {
            Color real;
            real = ColorTranslator.FromHtml(htmlCode);
            return real;
        }


        private void GameStateChanger(int changeTo)
        {
            Game.state = changeTo;
            if (Game.state == 0) //Deploy
            {
                INDICATORpnlDeploy.BackColor = (current.accentColour);
            }
            else if (Game.state == 1) //Attack
            {
                INDICATORpnlDeploy.BackColor = Color.LightGray;
                INDICATORpnlAttack.BackColor = (current.accentColour);
            }
            else if (Game.state == 2) //Reinforce
            {
                INDICATORpnlDeploy.BackColor = Color.LightGray;
                INDICATORpnlAttack.BackColor = Color.LightGray;
                INDICATORpnlReEnforce.BackColor = (current.accentColour);

            }
            else if (Game.state == 3) //Change turns & prompts
            {
                //Push to the turn swapper, and play the animation associated with a computer player's turn.
                //Youtube link: https://youtu.be/dkXek5V-920
                string html = "html head";
                html += " meta content='IE=Edge' http-equiv='X-UA-Compatible'/ ";
                html += " iframe id='video' src= 'https://youtube.com/embed/{0}' width='600' height='300' frameborder='0' allowfullscreen  /iframe ";  
                html += " /body  /html ";
                //wbVideo.Link = string.Format(html, "dkXek5V-920");

                //Play youtube video in wbVideo web browser
                //wbVideo.Navigate("https://youtu.be/dkXek5V-920");
                //wbVideo.Document.Write(html);
                //wbVideo.Refresh();
            }
        }

        private void frmGameScreen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Game.state == 3)
            {
                //If game is paused
                switch (e.KeyChar)
                {
                    case (char)Keys.Space:
                        PauseAction(0);
                        break;
                    case (char)Keys.Enter:
                        PauseAction(4);
                        break;
                    case (char)Keys.I:
                        PauseAction(1);
                        break;
                    case (char)Keys.O:
                        PauseAction(2);
                        break;
                    case (char)Keys.S:
                        PauseAction(3);
                        break;
                }
            }
        }

        private void tmrPauseCooldown_Tick(object sender, EventArgs e)
        {
            pauseCooldown = false;
            tmrPauseCooldown.Stop();
        }

        private void frmGameScreen_Resize(object sender, EventArgs e)
        {
            if (Game.newPlayer)
            {
                Game.newPlayer = false;
                ReturnToGameScreen();
            }
        }

        private void pnlSelectionBack_Click(object sender, EventArgs e)
        {
            pbBase.Refresh();
            if (!targetSelected)
            {
                sourceSelected = false;
                source.name = "";

                //Animate source viewer
                //Required location: 3, 775
                //Default location: 3, 701
                int animateSpeed = 2;
                int yCurrent = pnlSource.Location.Y;
                for (int i = 0; i < (74 / animateSpeed); i++)
                {
                    pnlSource.Location = new Point(3, yCurrent + (Convert.ToInt32(animateSpeed) * i));
                    pnlSource.Refresh();
                }

                pbSource.Image = Properties.Resources.source;
            }
            else
            {
                targetSelected = false;
                //target.name = "";

                lbSourceName.Text = source.name;
                pbSource.Image = Properties.Resources.source;
            }
        }

        private void troopCountDisplay(Point where, int num, string name)
        {
            pnlTroopCounter.Location = where;
            pnlTroopCounter.Visible = true;
            lbTroopCountInfo.Text = $"How many of your {num} troops would \r\nyou like to deploy to {name}?";
            btnTroopCountDisplay.Text = Convert.ToString(num);
        }
        private void troopCountDisplay(Point where, int num, string name, string info)
        {
            pnlTroopCounter.Location = where;
            pnlTroopCounter.Visible = true;
            lbTroopCountInfo.Text = info;
            btnTroopCountDisplay.Text = Convert.ToString(num);
        }

        private void pnlPauseResume_MouseEnter(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseResume, Properties.Resources.PlayButtonHover);
        }

        private void pnlPauseResume_MouseLeave(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseResume, Properties.Resources.PlayButtonDefault);
        }

        private void lbPauseResume_MouseEnter(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseResume, Properties.Resources.PlayButtonHover);
        }

        private void lbPauseResume_MouseLeave(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseResume, Properties.Resources.PlayButtonDefault);
        }

        private void pbPauseResume_MouseEnter(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseResume, Properties.Resources.PlayButtonHover);
        }

        private void pbPauseResume_MouseLeave(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseResume, Properties.Resources.PlayButtonDefault);
        }

        private void pnlPauseInvite_MouseEnter(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseInvite, Properties.Resources.InviteButtonHover);
        }

        private void pnlPauseInvite_MouseLeave(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseInvite, Properties.Resources.InviteButtonDefault);
        }

        private void bPauseInvite_MouseEnter(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseInvite, Properties.Resources.InviteButtonHover);
        }

        private void bPauseInvite_MouseLeave(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseInvite, Properties.Resources.InviteButtonDefault);
        }

        private void pbPauseInvite_MouseEnter(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseInvite, Properties.Resources.InviteButtonHover);
        }

        private void pbPauseInvite_MouseLeave(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseInvite, Properties.Resources.InviteButtonDefault);
        }

        private void pnlPauseOverview_MouseEnter(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseOverview, Properties.Resources.OverviewButtonHover);
        }

        private void pnlPauseOverview_MouseLeave(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseOverview, Properties.Resources.OverviewButtonDefault);
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseOverview, Properties.Resources.OverviewButtonHover);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseOverview, Properties.Resources.OverviewButtonDefault);
        }

        private void pbPauseOverview_MouseEnter(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseOverview, Properties.Resources.OverviewButtonHover);
        }

        private void pbPauseOverview_MouseLeave(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseOverview, Properties.Resources.OverviewButtonDefault);
        }

        private void pnlPauseSettings_MouseEnter(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseSettings, Properties.Resources.SettingsButtonHover);
        }

        private void pnlPauseSettings_MouseLeave(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseSettings, Properties.Resources.SettingsButtonDefault);
        }

        private void lbPauseSettings_MouseEnter(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseSettings, Properties.Resources.SettingsButtonHover);
        }

        private void lbPauseSettings_MouseLeave(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseSettings, Properties.Resources.SettingsButtonDefault);
        }

        private void pbPauseSettings_MouseEnter(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseSettings, Properties.Resources.SettingsButtonHover);
        }

        private void pbPauseSettings_MouseLeave(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseSettings, Properties.Resources.SettingsButtonDefault);
        }

        private void pnlPauseQuit_MouseEnter(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseQuit, Properties.Resources.QuitButtonHover);
        }

        private void pnlPauseQuit_MouseLeave(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseQuit, Properties.Resources.QuitButtonDefault);
        }

        private void lbPauseQuit_MouseEnter(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseQuit, Properties.Resources.QuitButtonHover);
        }

        private void lbPauseQuit_MouseLeave(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseQuit, Properties.Resources.QuitButtonDefault);
        }

        private void pbPauseQuit_MouseEnter(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseQuit, Properties.Resources.QuitButtonHover);
        }

        private void pbPauseQuit_MouseLeave(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseQuit, Properties.Resources.QuitButtonDefault);
        }

        private void pbPauseQuit_Click(object sender, EventArgs e)
        {
            PauseAction(4);
        }

        private void pnlPauseQuit_Click(object sender, EventArgs e)
        {
            PauseAction(4);
        }

        private void pnlPauseSettings_Click(object sender, EventArgs e)
        {
            PauseAction(3);
        }

        private void lbPauseSettings_Click(object sender, EventArgs e)
        {
            PauseAction(3);
        }

        private void pbPauseSettings_Click(object sender, EventArgs e)
        {
            PauseAction(3);
        }

        private void pnlPauseOverview_Click(object sender, EventArgs e)
        {
            PauseAction(2);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            PauseAction(2);
        }

        private void pbPauseOverview_Click(object sender, EventArgs e)
        {
            PauseAction(2);
        }

        private void pnlPauseInvite_Click(object sender, EventArgs e)
        {
            PauseAction(1);
        }

        private void bPauseInvite_Click(object sender, EventArgs e)
        {
            PauseAction(1);
        }

        private void pbPauseInvite_Click(object sender, EventArgs e)
        {
            PauseAction(1);
        }

        private void pnlPauseResume_Click(object sender, EventArgs e)
        {
            PauseAction(0);
        }

        private void pbPauseResume_Click(object sender, EventArgs e)
        {
            PauseAction(0);
        }

        private void pnlBase_Click(object sender, EventArgs e)
        {

        }

        private void pnlBase_MouseDown(object sender, MouseEventArgs e)
        {


        }

        private void changeTR(int a)
        {
            if (pnlTroopsRemaining.Visible)
            {
                pnlTroopsRemaining.Visible = false;
            }
            else
            {
                pnlTroopsRemaining.Visible = true;
                lbTroopsRemainingNumber.Text = Convert.ToString(a);
            }
        }

        private void btnTroopCountUp_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(btnTroopCountDisplay.Text) < current.troopPocket)
            {
                btnTroopCountDisplay.Text = Convert.ToString(Convert.ToInt32(btnTroopCountDisplay.Text) + 1);
            }

        }

        private void btnTroopCountDown_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(btnTroopCountDisplay.Text) > 0)
            {
                btnTroopCountDisplay.Text = Convert.ToString(Convert.ToInt32(btnTroopCountDisplay.Text) - 1);
            }
        }

        private void DEBUGbtnSwitchAttack_Click(object sender, EventArgs e)
        {
            GameStateChanger(1);
            pnlTroopCounter.Visible = false;
        }

        private void updateTroopDisplays()
        {
            try
            {
                for (int i = 0; i < regions.Length; i++)
                {
                    string labelName = $"lbREGION_{regions[i].name}";
                    Label lbRegion = this.Controls.Find(labelName, true).FirstOrDefault() as Label;
                    lbRegion.Text = Convert.ToString(regions[i].troopCount);
                }
            }
            catch
            {
                Game.Message("This region could not be selected\r\ndue to a technical error.", MSGpnlMessageGroup, MSGlbMessage);
            }
        }

        private void btnTroopDeploy_Click(object sender, EventArgs e)
        {
            pnlTroopCounter.Visible = false;
            pnlTroopsRemaining.Visible = false;
            Region deployTo = new Region();

            int deployCount = Convert.ToInt32(btnTroopCountDisplay.Text);
            current.troopPocket -= deployCount;

            switch (Game.state)
            {
                case 0:
                    deployTo = activeR;
                    deployTo.addTroops(deployCount);
                    break;
                case 1:
                    source.troopCount -= deployCount;
                    target.troopCount += deployCount;
                    Bitmap bmp = (Bitmap)pbBase.Image;
                    Point central = new Point(target.CentralX, target.CentralY);
                    FloodFill(bmp, central, (current.accentColour), bmp.GetPixel(central.X, central.Y), 200);

                    source = new Region();
                    sourceSelected = false;
                    target = new Region();
                    targetSelected = false;

                    int animateSpeed = 2;
                    int yCurrent = pnlSource.Location.Y;
                    for (int i = 0; i < (74 / animateSpeed); i++)
                    {
                        pnlSource.Location = new Point(3, yCurrent + (Convert.ToInt32(animateSpeed) * i));
                        pnlSource.Refresh();
                    }

                    break;
                case 2:
                    source.troopCount -= deployCount;
                    int a = rnd.Next(0, deployCount);
                    target.troopCount += (deployCount - a);
                    MessageBox.Show($"You lost {a} troops in transit.");

                    source = new Region();
                    sourceSelected = false;
                    target = new Region();
                    targetSelected = false;

                    animateSpeed = 2;
                    yCurrent = pnlSource.Location.Y;
                    for (int i = 0; i < (74 / animateSpeed); i++)
                    {
                        pnlSource.Location = new Point(3, yCurrent + (Convert.ToInt32(animateSpeed) * i));
                        pnlSource.Refresh();
                    }

                    this.WindowState = FormWindowState.Minimized;

                    break;
            }

            updateTroopDisplays();


            if (current.troopPocket <= 0)
            {
                GameStateChanger(1);
            }
        }

        private void pnlTroopCounter_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void btnAttack_Click(object sender, EventArgs e)
        {

        }

        private void DiminishTroop(Region whereFrom, int howMany)
        {
            for (int i = 0; i < howMany; i++)
            {
                whereFrom.troopCount -= 1;
                updateTroopDisplays();
                //Destroy animation
                //here
                if (whereFrom.troopCount <= 0)
                    return;
            }
            if (whereFrom.troopCount <= 0)
            {
                //Region taken over
                whereFrom.SetController(current.gamePlayerID);
            }
        }

        private void pnlAttackButton_Click(object sender, EventArgs e)
        {
            pnlAttackButton.Visible = false;
            pnlAttackButton.Enabled = false;

            //Has to take into account dice rolls (and more importantly) troop count.
            int sourceCount = source.troopCount;
            int targetCount = target.troopCount;
            int countDifference = sourceCount - targetCount; //Minus here means target has more troops.

            //First 3 dice belong to source, next 3 belong to target
            int[] dice = new int[6];
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = rnd.Next(0, 7);
            }

            int sourceAVGTC = (dice[0] + dice[1] + dice[2]) / 3;
            int targetAVGTC = (dice[3] + dice[4] + dice[5]) / 3;
            int AVGTCdiff = Math.Abs(sourceAVGTC - targetAVGTC);

            if (sourceCount / targetCount == 1)
            {
                //Equal troop count - only dice rolls matter

                if (AVGTCdiff < 0)
                {
                    //Target won
                    AVGTCdiff = Math.Abs(AVGTCdiff);
                    DiminishTroop(source, AVGTCdiff);
                    DiminishTroop(target, 1);
                }
                else if (AVGTCdiff > 0)
                {
                    //Source won
                    DiminishTroop(target, AVGTCdiff);
                    DiminishTroop(source, 1);
                }
                else
                {
                    //Nobody wins
                }
            }
            else if (sourceCount > targetCount)
            {
                //Tilt in favour of source
                DiminishTroop(target, countDifference);
                if (targetCount > 1)
                {
                    DiminishTroop(source, countDifference);
                }
            }
            else
            {
                //Tilt in favour of target
                DiminishTroop(source, countDifference);
                if (sourceCount > 1)
                {
                    DiminishTroop(target, countDifference);
                }
            }

            if (target.troopCount <= 0)
            {
                //Target region taken over
                target.SetController(current.gamePlayerID);
                occupyRegion(source, target);
            }
            if (source.troopCount <= 0)
            {
                //Source region lost
                int animateSpeed = 2;
                int yCurrent = pnlSource.Location.Y;
                for (int i = 0; i < (74 / animateSpeed); i++)
                {
                    pnlSource.Location = new Point(3, yCurrent + (Convert.ToInt32(animateSpeed) * i));
                    pnlSource.Refresh();
                }
                target = new Region();
                source = new Region();
                sourceSelected = false;
                targetSelected = false;
            }
        }

        private void occupyRegion(Region source, Region target)
        {
            target.SetController(source.owner);
            target.colour = source.colour;

            current.troopPocket = source.troopCount - 1;
            pnlTroopCounter.Visible = true;
            lbTroopCountInfo.Text = $"How many of your {current.troopPocket} troops would \r\nyou like to deploy to {target.name}?";
            btnTroopCountDisplay.Text = Convert.ToString(current.troopPocket);

            updateTroopDisplays();
        }

        private void pbBase_Click(object sender, EventArgs e)
        {

        }

        private void pnlSelectionBack_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEndAttackMode_Click(object sender, EventArgs e)
        {
            if(Game.state == 1)
            {
                GameStateChanger(2);
                this.Text = "End Reinforcement";
            }
            else
            {
                GameStateChanger(3);
            }
        }

        private void btnMoveTroops_Click(object sender, EventArgs e)
        {
            pnlAttackButton.Visible = false;
            pnlAttackButton.Enabled = false;

            Point a = new Point(source.CentralX, source.CentralY);
            troopCountDisplay(a, source.troopCount - 1, source.name, $"How many of your {source.troopCount - 1} troops would \r\nyou like to move?");
        }
    }
}
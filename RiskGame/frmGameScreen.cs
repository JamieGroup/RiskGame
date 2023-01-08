using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
        Region source = new Region();
        Region target = new Region();

        public frmGameScreen()
        {
            InitializeComponent();
        }

        private void frmGameScreen_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            pnlPause.BringToFront();
            if(!frmLogin.human.DEBUGSkipToGame)
                Application.OpenForms["frmDashboard"].Close();
            int AICount = Game.AICount;
            int OthersCount = Game.OthersCount;
            int playerCount = AICount + OthersCount;
            Game.currentPlayer = 0;
            pnlPause.Location = new Point(-455, 0);

            
            Game.calcPlayers();
            new frmPlayerSwapper().Show();

            pnlSource.Location = new Point(3, 775);

            pbBase.BackColor = Color.FromArgb(153, 220, 243);
            if(!frmLogin.human.DEBUGIgnoreAssigned)
            {
                AssignRegions(playerCount + 1);
            }
        }

        public void ReturnToGameScreen()
        {
            Plys current;
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

            switch(Game.state)
            {
                case 0:
                    //Deploy
                    INDICATORpnlDeploy.BackColor = ColorTranslator.FromHtml(current.accentColour);
                    break;
                case 1:
                    //Attack
                    INDICATORpnlDeploy.BackColor = Color.LightGray;
                    INDICATORpnlAttack.BackColor = ColorTranslator.FromHtml(current.accentColour);
                    break;
                case 2:
                    //ReEnforce
                    INDICATORpnlDeploy.BackColor = Color.Gray;
                    INDICATORpnlAttack.BackColor = Color.Gray;
                    INDICATORpnlReEnforce.BackColor = ColorTranslator.FromHtml(current.accentColour);
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
                regions[i] = new Region(allRegionData[i].Split('~')[0]);
                int b = rnd.Next(0, a);
                regions[i].SetController(b);
                regions[i].SetTerritory();
                regions[i].SetPoint(Convert.ToInt32(allRegionData[i].Split('~')[1].Split(',')[0]), Convert.ToInt32(allRegionData[i].Split('~')[1].Split(',')[1]));
                Color colour;
                if(b==0)
                    colour = System.Drawing.ColorTranslator.FromHtml(frmLogin.human.accentColour);
                else if(b==1)
                    colour = System.Drawing.ColorTranslator.FromHtml(Pl2.accentColour);
                else
                    colour = System.Drawing.ColorTranslator.FromHtml(Pl3.accentColour);
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
                pnl.BringToFront();

                Label lb = new Label();
                lb.Text = Convert.ToString(rnd.Next(1,4));
                lb.ForeColor = Color.Black;
                pnl.Controls.Add(lb);
                lb.Location = new Point(/*regions[i].CentralX, regions[i].CentralY*/15,5);
                lb.BackColor = Color.Transparent;
                lb.Font = new Font("Segoe UI", 18, FontStyle.Bold);
                lb.Click += new EventHandler(troopDisplay_Click);
                lb.BringToFront();
            }
            rnd.Next(1, a);
        }

        private void troopDisplay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You've clicked a troop display!\r\nDon't do that yet please!\r\nTry clicking on the region itself!", "TEMPORARY!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    AnimatePauseScreen(0);
                }
                else
                {
                    //Unpause
                    AnimatePauseScreen(1);
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
                for(int i = 0; i < (460/animateSpeed); i++)
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
            switch(ID)
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
                    if (IsClose(bmp.GetPixel(a.X, a.Y), Color.White))
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
                    if (IsClose(bmp.GetPixel(a.X, a.Y), original, threshold))
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
            Region tempSelection;

            //Attack Mode Active
            if (Game.state == 0)
            {
                tempSelection = RegionID(mousePosition);
                if (!sourceSelected && tempSelection.owner == Game.currentPlayer)
                {
                    //Select Source
                    source.name = "";
                    if(tempSelection.name == "")
                    {
                        //Do nothing
                    }
                    else
                    {
                        sourceSelected = true;
                        source = tempSelection;
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
                    }
                }
                else if(!sourceSelected)
                {
                    MessageBox.Show("You have clicked on a region that is not yours.", "Please select a region that is yours.");
                }
                else if (sourceSelected && tempSelection.owner != Game.currentPlayer)
                {
                    //Select Target
                    target.name = "";
                    if (tempSelection.name == "")
                    {
                        //Do nothing
                    }
                    else
                    {
                        targetSelected = true;
                        target = tempSelection;
                        lbSourceName.Text = source.name + " -> " + target.name;
                        pbSource.Image = Properties.Resources.target;
                    }
                }
                else
                {
                    MessageBox.Show("You can't invade your own region!", "Please select a region that is not yours.");
                }
            }    

            //DEBUG MODE
            if(frmLogin.human.DEBUGIgnoreAssigned)
            {
                DEBUGClickMode(new Point(e.X, e.Y));
            }
        }

        private Region RegionID(Point test)
        {
            Region regionSuggestion = new Region();

            //Step 1: Save the colour of the clicked pixel.
            //Step 2: Save this colour again, but slightly changed.
            //Step 3: Flood fill using this slightly changed colour.
            //Step 4: Compare the points in regions.conf to see which one matches this SLIGHTLY CHANGED colour.
            //Step 5: If there are no matches, user did not click on a region, sourceSuggestion is "invalid", checked by tempSource.
            //Step 6: If there is a match, save the region's name and ID, change the colour back to the originally saved colour, then return this region information.

            Bitmap bmp = (Bitmap)pbBase.Image;
            Color pixelColour = bmp.GetPixel(test.X, test.Y);

            Color lighterPixelColour = ControlPaint.Light(pixelColour);

            FloodFill(bmp, test, lighterPixelColour, pixelColour, 10);

            string[] regionData = File.ReadAllLines("regions.conf");
            for(int i = 0; i<regionData.Length; i++)
            {
                string tempName = regionData[i].Split('~')[0];
                Point tempPoint = new Point(Convert.ToInt32(regionData[i].Split('~')[1].Split(',')[0]), Convert.ToInt32(regionData[i].Split('~')[1].Split(',')[1]));

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
            Color change = ColorTranslator.FromHtml(frmLogin.human.accentColour);
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
            if(!targetSelected)
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
                target.name = "";

                lbSourceName.Text = source.name;
                pbSource.Image = Properties.Resources.source;
            }
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
            if(pnlTroopsRemaining.Visible)
            {
                pnlTroopsRemaining.Visible = false;
            }
            else
            {
                pnlTroopsRemaining.Visible = true;
                lbTroopsRemainingNumber.Text = Convert.ToString(a);
            }
        }
    }
}

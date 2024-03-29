﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace RiskGame
{
    class Region
    {
        public int owner { get; set; }
        public string territory { get; set; }
        public string name { get; set; }
        public int CentralX { get; set; }
        public int CentralY { get; set; }
        public string colour { get; set; }
        public int troopCount;

        public Region()
        {
            owner = -1;
            territory = "none";
            name = "none";
            CentralX = 0;
            CentralY = 0;
        }

        public Region(string _name)
        {
            name = _name;
        }

        public void addTroops(int _addTroops)
        {
            troopCount += _addTroops;
        }

        public void changeColour(Bitmap bmp, Color newColour)
        {
            FloodFill(bmp, new Point(CentralX, CentralY), newColour);
        }

        public void SetController(int _owner)
        {
            owner = _owner;
        }
        public void SetTerritory()
        {
            territory = name.Split('_')[0];
        }
        public string GetOwner()
        {
            return $"{owner}";
        }
        public void SetPoint(int x, int y)
        {
            CentralX = x;
            CentralY = y;
        }

        public bool Closeness(Region source, Region potentialTarget)
        {
            bool close = false;

            string[] relations = File.ReadAllLines("relations.conf");
            for (int i = 0; i < relations.Length; i++)
            {
                string[] relationList = relations[i].Split('~');
                if (relationList[0] == source.name)
                {

                    for (int g = 0; g < relationList.Length; g++)
                    {
                        if (relationList[g] == potentialTarget.name)
                        {
                            close = true;
                        }
                    }
                }
            }

            return close;
        }

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
            return;
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
    }
}

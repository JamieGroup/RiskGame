using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskGame
{
    class FloodFill
    {
        //public int[][] floodFill(int[,] image, int sr, int sc, int newColor)
        //{
        //    int[,] directions = { { 1,0},{ -1,0},{ 0,1},{ 0,-1} };
        //    int oldColour = image[sr,sc];
        //    dfsFloodFill(image, sr, sc, newColor, oldColour, directions);
        //    return image;
        //}

        //private void dfsFloodFill(int[,] image, int sr, int sc, int newColor, int oldColour, int[][] directions)
        //{
        //    if (checkCondition(sr, sc, image, oldColour, newColor)) return;
        //    image[sr][sc] = newColor;
        //    for (int[] direction:directions)
        //    {
        //        dfsFloodFill(image, sr + direction[0], sc + direction[1], newColor, oldColour, directions);
        //    }
        //}

        //private bool checkCondition(int sr, int sc, int[][] image, int oldColour, int newColor)
        //{
        //    if (sr < 0 || sc < 0 || sr >= image.length || sc >= image[0].length
        //            || image[sr][sc] == newColor || image[sr][sc] != oldColour)
        //        return true;
        //    return false;
        //}
    }
}

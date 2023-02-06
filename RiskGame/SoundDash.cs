using System;

namespace RiskGame
{
    internal class SoundDash
    {
        public static void Yes()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            Random rnd = new Random();
            rnd.Next(1, 3);
            player.Play();
        }
        public static void No()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            Random rnd = new Random();
            rnd.Next(1, 3);
            player.Play();
        }
    }
}

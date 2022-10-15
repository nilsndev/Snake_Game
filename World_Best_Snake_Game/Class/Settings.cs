using System;
using System.Collections.Generic;
using System.Text;

namespace World_Best_Snake_Game
{
    public class Settings
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static string Direction { get; set; }

        public Settings()
        {
            Width = 16;
            Height = 16;
            Direction = "right";
        }

    }
}

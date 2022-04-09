﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife2._0_Alpha
{
    class Variables
    {
    }
    static class Data
    {
        // Settings
        public static int resolutionData = 10;
        public static int densityData = 2;
        public static bool rbAutoData = true;
        public static bool rbDrawData = false;
        // Game
        public static int cols;
        public static int rows;
        public static bool[,] saveGame;
        // Figures
        public static int smallColsData;
        public static int smallRowsData;
        public static bool[,] smallFieldData;
        public static bool[,] saveFiguresData;
    }
    public class GameS
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool[] Game_Zone { get; set; }
        public int resolution { get; set; }
        public int col { get; set; }
        public int row { get; set; }
    }
}

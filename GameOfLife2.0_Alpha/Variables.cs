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
        // Figures
        public static int smallColsData;
        public static int smallRowsData;
        public static bool[,] smallFieldData;
        public static bool[,] saveFiguresData;
    }
}
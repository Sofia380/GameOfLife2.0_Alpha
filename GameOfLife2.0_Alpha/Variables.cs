using System;
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
        public static bool startCheckerData = false;
        // Figures
        public static int smallColsData;
        public static int smallRowsData;
        public static int smallResolution;
        public static bool[,] smallFieldData;
        public static bool[,] saveFiguresData;
        public static FigureS UpdateFigure;
        public static bool CheckChangeFigures = false;
        //
        public static bool[,] fieldSaved;
        public static bool startSavedGame = false;
        public static string RenameGame;
        public static bool CheckChangeNane = false;


    }
    public class GameS
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool[] Game_Zone { get; set; }
        public int resolution { get; set; }
        public int col { get; set; }
        public int row { get; set; }
    }
    public class FigureS
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool[] FigureZone { get; set; }
        public int resolution { get; set; }
        public int col { get; set; }
        public int row { get; set; }
    }
}

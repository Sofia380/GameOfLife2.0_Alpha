using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife2._0_Alpha
{
    public partial class GameField : Form
    {
        AppHelp AppHelp;
        SaveGameWindow SaveGameWindow;
        EditorGame EditorGame;
        EditorFigures EditorFigures;
        CreateFigures CreateFigures;
        ChangeNameGame ChangeNameGame;
        SmallEditorFigures SmallEditorFigures;
        Settings Settings;

        public int smallCols;
        public int smallRows;
        public bool[,] smallFild;

        public int resolution;
        public int density;
        public bool autoCheck = Data.rbAutoData;
        public int rows, cols;
        public bool[,] field;
        public bool[,] saveGame;
        private Graphics graphics;

        public GameField()
        {
            InitializeComponent();
            bStop.Enabled = false;
            bContinue.Enabled = false;
            bReset.Enabled = false;
            foreach(ToolStripMenuItem m in menuStrip1.Items)
            {
                SetWhiteColor(m);
            }
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new Cols());
            this.AppHelp = new AppHelp();
            this.SaveGameWindow = new SaveGameWindow();
            this.EditorGame = new EditorGame();
            this.EditorFigures = new EditorFigures();
            this.CreateFigures = new CreateFigures();
            this.ChangeNameGame = new ChangeNameGame();
            this.SmallEditorFigures = new SmallEditorFigures();
            this.Settings = new Settings();

        }

        private void StartGame()
        {
            Data.startCheckerData = true;
            bStop.Enabled = true;
            bReset.Enabled = true;
            bStart.Enabled = false;
            resolution = Data.resolutionData;
            density = Data.densityData;
            autoCheck = Data.rbAutoData;
            if (timer1.Enabled)
                return;
            rows = pictureBox1.Height / resolution;
            cols = pictureBox1.Width / resolution;
            Data.cols = cols;
            Data.rows = rows;
            field = new bool[cols, rows];
            saveGame = new bool[cols, rows];

            if (autoCheck == false)
                return;

            Random random = new Random();
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    field[x, y] = random.Next(density) == 1;
                }
            }

            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);
            saveGame = field;
            Data.saveGame = saveGame;
            timer1.Start();
        }

        private void StopGame()
        {
            if (!timer1.Enabled)
                return;
            bContinue.Enabled = true;
            bReset.Enabled = true;
            bStart.Enabled = false;
            timer1.Stop();
        }

        private int CountNeighbrous(int x, int y)
        {
            int count = 0;

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    var col = (x + i + cols) % cols;
                    var row = (y + j + rows) % rows;
                    var isSelfChecking = col == x && row == y;
                    var hasLife = field[col, row];

                    if (hasLife && !isSelfChecking)
                        count++;
                }
            }

            return count;
        }

        private void NextGeneration()
        {
            graphics.Clear(Color.Black);

            var newFlield = new bool[cols, rows];

            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    var neighboursCount = CountNeighbrous(x, y);
                    var hasLife = field[x, y];

                    if (!hasLife && neighboursCount == 3)
                        newFlield[x, y] = true;
                    else if (hasLife && (neighboursCount < 2 || neighboursCount > 3))
                        newFlield[x, y] = false;
                    else
                        newFlield[x, y] = field[x, y];

                    if (hasLife)
                        graphics.FillRectangle(Brushes.Crimson, x * resolution, y * resolution, resolution, resolution);
                }
            }
            field = newFlield;
            pictureBox1.Refresh();
        }



        private void спарвкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AppHelp.Show();
            this.AppHelp.Activate();
        }

        private void фигурыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.EditorFigures.Show();
            this.EditorFigures.Activate();
        }

        private void сохранитьИгруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveGameWindow.Show();
            this.SaveGameWindow.Activate();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        


        private void настройкаИгровогоПроцессаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Settings.Show();
            this.Settings.Activate();
        }

        private void темыToolStripMenuItem_Click(object sender, EventArgs e) // Надо реализовать
        {

        }

        private void моиСохраненияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.EditorGame.Show();
            this.EditorGame.Activate();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            StartGame();
            if (autoCheck == false)
            {
                if (timer1.Enabled)
                    return;
                rows = pictureBox1.Height / resolution;
                cols = pictureBox1.Width / resolution;
                field = new bool[cols, rows];
                bStop.Enabled = false;
                bContinue.Enabled = true;
                bReset.Enabled = true;
            }
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            StopGame();
        }

        private void bContinue_Click(object sender, EventArgs e)
        {
            timer1.Start();
            bContinue.Enabled = false;
            bStart.Enabled = false;
            bStop.Enabled = true;
            bReset.Enabled = true;
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены?","Внимание",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2);
            if (result == DialogResult.OK)
            {
                for (int i = 0; i < cols; i++)
                {
                    for (int j = 0; j < rows; j++)
                    {
                        field[i, j] = false;
                    }
                }
                graphics.Clear(Color.Black);
                pictureBox1.Refresh();
                StopGame();
                bStop.Enabled = false;
                bContinue.Enabled = false;
                bReset.Enabled = false;
                bStart.Enabled = true;
                Data.startCheckerData = false;
            }
        }

        private void bChooseFigure_Click(object sender, EventArgs e)
        {
            this.EditorFigures.Show();
            this.EditorFigures.Activate();
        }

        private void bChooseSave_Click(object sender, EventArgs e)
        {
            this.EditorGame.Show();
            this.EditorGame.Activate();
        }

        private void bSaveGame_Click(object sender, EventArgs e)
        {
            this.SaveGameWindow.Show();
            this.SaveGameWindow.Activate();
        }

        private void bCreateFigure_Click(object sender, EventArgs e)
        {
            this.CreateFigures.Show();
            this.CreateFigures.Activate();
        }

        private void bSettings_Click(object sender, EventArgs e)
        {
            this.Settings.Show();
            this.Settings.Activate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NextGeneration();
        }
        
        public class Cols : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.FromArgb(51, 153, 255); }
            }

            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.FromArgb(51, 153, 255); }
            }

            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.FromArgb(51, 153, 255); }
            }

            public override Color MenuItemPressedGradientBegin
            {
                get { return Color.FromArgb(51, 153, 255); }
            }

            public override Color MenuItemPressedGradientMiddle
            {
                get { return Color.FromArgb(51, 153, 255); }
            }

            public override Color MenuItemPressedGradientEnd
            {
                get { return Color.FromArgb(51, 153, 255); }
            }

            public override Color ToolStripDropDownBackground
            {
                get { return System.Drawing.SystemColors.ControlDarkDark; }
            }

            public override Color ImageMarginGradientBegin
            {
                get { return System.Drawing.SystemColors.ControlDarkDark; }
            }

            public override Color ImageMarginGradientEnd
            {
                get { return System.Drawing.SystemColors.ControlDarkDark; }
            }

            public override Color ImageMarginGradientMiddle
            {
                get { return System.Drawing.SystemColors.ControlDarkDark; }
            }

            public override Color MenuItemBorder
            {
                get { return Color.FromArgb(51, 153, 255); }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (timer1.Enabled)
                return;

            if (e.Button == MouseButtons.Left)
            {
                if (bStart.Enabled == true)
                {
                    MessageBox.Show("Начните игру!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                var validationPassed = ValidateMousePosition(x, y);
                if (validationPassed)
                {
                    field[x, y] = true;
                    graphics.FillRectangle(Brushes.Blue, x * resolution, y * resolution, resolution, resolution);
                    pictureBox1.Refresh();
                }
                saveGame = field;
                Data.saveGame = saveGame;
            }
            if (e.Button == MouseButtons.Right)
            {
                if (bStart.Enabled == true)
                {
                    MessageBox.Show("Начните игру!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                var validationPassed = ValidateMousePosition(x, y);
                if (validationPassed)
                {
                    field[x, y] = false;
                    graphics.FillRectangle(Brushes.Black, x * resolution, y * resolution, resolution, resolution);
                    pictureBox1.Refresh();
                }
                saveGame = field;
                Data.saveGame = saveGame;
            }
            if (e.Button == MouseButtons.Middle)
            {
                if (bStart.Enabled == true)
                {
                    MessageBox.Show("Начните игру!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                var validationPassed = ValidateMousePosition(x, y);
                if (validationPassed)
                {
                    PasteProcessing(x, y);
                    GraphicBox();
                    pictureBox1.Refresh();
                }
                saveGame = field;
                Data.saveGame = saveGame;
            }
        }

        private bool ValidateMousePosition(int x, int y)
        {
            return x >= 0 && y >= 0 && x < cols && y < rows;
        }

        private void GraphicBox()
        {
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (field[i, j])
                        graphics.FillRectangle(Brushes.Blue, i * resolution, j * resolution, resolution, resolution);
                }
            }
        }

        private void PasteProcessing(int x, int y)
        {
            int x1 = x, y1 = y, countx1 = 0, county1 = 0;
            if ((x1 + smallCols) <= cols && (y1 + smallRows) <= rows)
            {
                for (int i = 0; i < smallCols; i++)
                {
                    y1 = y;
                    for (int j = 0; j < smallRows; j++)
                    {
                        if (field[x1, y1] || smallFild[i, j])
                            field[x1, y1] = true;

                        y1 += 1;
                        if (county1 == smallRows)
                        {
                            y1 = y;
                            county1 = 0;
                        }
                    }
                    x1 += 1;
                    if (countx1 == smallCols)
                    {
                        x1 = x;
                        countx1 = 0;
                    }
                }
            }
            pictureBox1.Refresh();
        }

        private void SetWhiteColor(ToolStripMenuItem item)
        {
            item.ForeColor = Color.White;
            foreach (ToolStripMenuItem it in item.DropDownItems)
            {
                SetWhiteColor(it);
            }
        }
    }
}

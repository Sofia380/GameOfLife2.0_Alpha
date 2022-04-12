using LiteDB;
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
    public partial class SmallEditorFigures : Form
    {
        public int rows, cols;
        public int resolution;
        public bool[,] field;
        private Graphics graphics;

        public SmallEditorFigures()
        {
            InitializeComponent();
            bSave.Enabled = false;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Visible = false;
            }
            base.OnFormClosing(e);
        }

        private void StartEdit()
        {
            bStart.Enabled = false;
            bSave.Enabled = true;
            tbSaveGame.Enabled = false;
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbSaveGame.Text) || String.IsNullOrWhiteSpace(tbSaveGame.Text))
            {
                MessageBox.Show("Вы не ввели имя!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            GraphicBox();
            StartEdit();
        }
        private bool[,] ArrayToMatrix(bool[] Arr, int cols, int rows)
        {
            var newfield = new bool[cols, rows];
            int count = 0;
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    newfield[i, j] = Arr[count];
                    count++;
                }
            }
            return newfield;
        }

        private bool[] MatrixToArray()
        {
            var size = cols * rows;
            var Arr = new bool[size];
            int count = 0;
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Arr[count] = field[i, j];
                    count++;

                }
            }
            return Arr;
        }

        private void UpdateFigure(FigureS figure, string name)
        {
            using (var db = new LiteDatabase(@"GameDB.db"))
            {
                var Save_game = db.GetCollection<FigureS>("save_figure");
                figure.Name = name;
                figure.FigureZone = MatrixToArray();
                Save_game.Update(figure);
                Data.CheckChangeFigures = true;
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            UpdateFigure(Data.UpdateFigure, tbSaveGame.Text);
            graphics.Clear(Color.Black);
            tbSaveGame.Enabled = true;
            bStart.Enabled = true;
            bSave.Enabled = false;
            pbFigure.Refresh();
            Hide();
        }

        private void bCansel_Click(object sender, EventArgs e)
        {
            if (bStart.Enabled == false)
            {
                DialogResult result = MessageBox.Show("Вы уверены?", "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
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
                    pbFigure.Refresh();
                }
            }
            graphics.Clear(Color.Black);
            pbFigure.Refresh();
            tbSaveGame.Enabled = true;
            bStart.Enabled = true;
            bSave.Enabled = false;
            tbSaveGame.Text = "";
            Hide();
        }

        private void pbFigure_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (bStart.Enabled == true)
                {
                    MessageBox.Show("Начните редактирование фигуры!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                var validationPassed = ValidateMousePosition(x, y);
                if (validationPassed)
                {
                    field[x, y] = true;
                    graphics.FillRectangle(Brushes.Red, x * resolution, y * resolution, resolution, resolution);
                    pbFigure.Refresh();
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                if (bStart.Enabled == true)
                {
                    MessageBox.Show("Начните редактирование фигуры!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                var validationPassed = ValidateMousePosition(x, y);
                if (validationPassed)
                {
                    field[x, y] = false;
                    graphics.FillRectangle(Brushes.Black, x * resolution, y * resolution, resolution, resolution);
                    pbFigure.Refresh();
                }
            }
        }

        private bool ValidateMousePosition(int x, int y)
        {
            return x >= 0 && y >= 0 && x < cols && y < rows;
        }

        private void SmallEditorFigures_Activated_1(object sender, EventArgs e)
        {
            tbSaveGame.Text = Data.UpdateFigure.Name;

            resolution = Data.UpdateFigure.resolution;
            rows = Data.UpdateFigure.row;
            cols = Data.UpdateFigure.col;
            field = new bool[cols, rows];
            field = ArrayToMatrix(Data.UpdateFigure.FigureZone, rows, cols);
            pbFigure.Image = new Bitmap(pbFigure.Width, pbFigure.Height);
            graphics = Graphics.FromImage(pbFigure.Image);
            GraphicBox();
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
    }
}

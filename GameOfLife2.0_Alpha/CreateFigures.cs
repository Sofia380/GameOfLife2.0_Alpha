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
    public partial class CreateFigures : Form
    {
        public int rows, cols;
        public int resolution;
        public bool[,] field;
        private Graphics graphics;

        public CreateFigures()
        {
            InitializeComponent();
            tbResolution.Value = 10;
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

        private void StartCreate()
        {
            resolution = (int)tbResolution.Value;
            rows = pbFigure.Height / resolution;
            cols = pbFigure.Width / resolution;
            field = new bool[cols, rows];
            pbFigure.Image = new Bitmap(pbFigure.Width, pbFigure.Height);
            graphics = Graphics.FromImage(pbFigure.Image);
            bStart.Enabled = false;
            bSave.Enabled = true;
            tbResolution.Enabled = false;
        }

        private void tbSaveGame_TextChanged(object sender, EventArgs e)
        {
            ////
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            StartCreate();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            ////
            Hide();
        }

        private void bCancel_Click(object sender, EventArgs e)
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
                    bStart.Enabled = true;
                    tbResolution.Enabled = true;
                }
            }
            Hide();
        }

        private void pbFigure_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (bStart.Enabled == true)
                {
                    MessageBox.Show("Начните создание фигуры!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("Начните создание фигуры!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}

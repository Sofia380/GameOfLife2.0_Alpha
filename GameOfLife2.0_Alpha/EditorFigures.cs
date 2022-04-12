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
    public partial class EditorFigures : Form
    {
        SmallEditorFigures SmallEditorFigures;
        private FigureS Figure;

        public EditorFigures()
        {
            InitializeComponent();
            synchronizeBD();
            this.SmallEditorFigures = new SmallEditorFigures();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Visible = false;
            }
            base.OnFormClosing(e);
            synchronizeBD();
        }

        private void synchronizeBD()
        {
            using (var db = new LiteDatabase(@"GameDB.db"))
            {
                var Save_game = db.GetCollection<FigureS>("save_figure");
                var save = Save_game.FindAll();
                lbFiguresEditor.DataSource = save.ToList();
                lbFiguresEditor.DisplayMember = "Name";
                lbFiguresEditor.ValueMember = "Id";
                lbFiguresEditor.SelectedIndexChanged += lbFiguresEditor_SelectedIndexChanged;
            }
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

        private void LoadFigure(FigureS figure)
        {
            if (figure.col == 0 || figure.row == 0)
                return;
            Data.smallColsData = figure.col;
            Data.smallRowsData = figure.row;
            Data.smallResolution = figure.resolution;
            Data.saveFiguresData = ArrayToMatrix(figure.FigureZone, figure.col, figure.row);
        }

        private void DelFigure(FigureS figure)
        {
            using (var db = new LiteDatabase(@"GameDB.db"))
            {
                var Save_game = db.GetCollection<FigureS>("save_figure");
                Save_game.Delete(x => x.Id.Equals(figure.Id));
            }
        }

        private void lbFiguresEditor_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = lbFiguresEditor.SelectedValue;
            //// получаем весь выделенный объект
            Figure = (FigureS)lbFiguresEditor.SelectedItem;
            Data.UpdateFigure = Figure;
        }

        private void bUse_Click(object sender, EventArgs e)
        {
            LoadFigure(Figure);
            synchronizeBD();
            Hide();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            this.SmallEditorFigures.Show();
            this.SmallEditorFigures.Activate();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            DelFigure(Figure);
            synchronizeBD();
        }

        private void использоватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFigure(Figure);
            synchronizeBD();
            Hide();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SmallEditorFigures.Show();
            this.SmallEditorFigures.Activate();
        }

        private void переименоватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelFigure(Figure);
            synchronizeBD();
        }

        private void EditorFigures_Activated(object sender, EventArgs e)
        {
            synchronizeBD();
            if (Data.CheckChangeFigures)
            {
                Data.CheckChangeFigures = false;
                synchronizeBD();
            }
        }
    }
}

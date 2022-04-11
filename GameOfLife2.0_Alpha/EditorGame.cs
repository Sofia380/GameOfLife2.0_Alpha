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

    public partial class EditorGame : Form
    {
        ChangeNameGame ChangeNameGame;
        private GameS Game; 

        public EditorGame()
        {
            InitializeComponent();
            synchronizeBD();
            this.ChangeNameGame = new ChangeNameGame();
        }

        private void synchronizeBD() {
            using (var db = new LiteDatabase(@"GameDB.db"))
            {
                var Save_game = db.GetCollection<GameS>("save_games");
                var save = Save_game.FindAll();
                lbFiguresEditor.DataSource = save.ToList();
                lbFiguresEditor.DisplayMember = "Name";
                lbFiguresEditor.ValueMember = "Id";
                lbFiguresEditor.SelectedIndexChanged += lbFiguresEditor_SelectedIndexChanged;
            }
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

        private void lbFiguresEditor_SelectedIndexChanged(object sender, EventArgs e)
        { 
                var id = lbFiguresEditor.SelectedValue;
                //// получаем весь выделенный объект
                Game = (GameS)lbFiguresEditor.SelectedItem;
        }

        private void EditorGame_Activated(object sender, EventArgs e)
        {
            synchronizeBD();
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

        private void LoadGame(GameS game) 
        {
            if (game.col == 0 || game.row == 0)
                return;
            Data.cols = game.col;
            Data.rows = game.row;
            Data.resolutionData = game.resolution;
            Data.fieldSaved = ArrayToMatrix(game.Game_Zone, game.col, game.row);
        }

        private void использоватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // загружай в Data.fieldSaved и разкоменть код в GameField
            LoadGame(Game);
            synchronizeBD();
            Hide();
        }

        private void переименоватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.ChangeNameGame.Show();
            this.ChangeNameGame.Activate();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lbFiguresEditor_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                int index = lbFiguresEditor.IndexFromPoint(e.Location);
                if(index >= 0)
                {
                    lbFiguresEditor.SelectedIndex = index;
                    contextMenuStrip1.Show(this.lbFiguresEditor, e.Location);
                }
            }
        }

        private void bUse_Click(object sender, EventArgs e)
        {
            // загружай в Data.fieldSaved и разкоменть код в GameField
            LoadGame(Game);
            synchronizeBD();
            Hide();
        }

        private void bChangeName_Click(object sender, EventArgs e)
        {
            this.ChangeNameGame.Show();
            this.ChangeNameGame.Activate();
        }
    }
}

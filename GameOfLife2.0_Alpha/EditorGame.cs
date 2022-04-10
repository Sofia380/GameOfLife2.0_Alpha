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
        public EditorGame()
        {
            InitializeComponent();
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
            
        }

        private void lbFiguresEditor_SelectedIndexChanged(object sender, EventArgs e)
        { 
                var id = lbFiguresEditor.SelectedValue;
                //// получаем весь выделенный объект
                GameS Game = (GameS)lbFiguresEditor.SelectedItem;
                //
            
        }

        private void bCancel_Click(object sender, EventArgs e)
        {

        }
    }
}

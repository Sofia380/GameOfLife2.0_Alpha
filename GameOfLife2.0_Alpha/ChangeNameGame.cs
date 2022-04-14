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
    public partial class ChangeNameGame : Form
    {
        public ChangeNameGame()
        {
            InitializeComponent();
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

        private void bSave_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(tbSaveGame.Text) || String.IsNullOrWhiteSpace(tbSaveGame.Text))
            {
                MessageBox.Show("Вы не ввели имя!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Data.RenameGame = tbSaveGame.Text;
            Data.CheckChangeNane = true;
            tbSaveGame.Text = "";
            Hide();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            tbSaveGame.Text = "";
            Hide();
        }
    }
}

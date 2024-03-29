﻿using LiteDB;
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
    public partial class SaveGameWindow : Form
    {
        public bool[,] saveGame;
        public SaveGameWindow()
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

        private bool[] MatrixToArray()
        {
            var size = Data.cols * Data.rows;
            var Arr = new bool[size];
            saveGame = Data.saveGame;
            int count = 0;
            for (int i = 0; i < Data.cols; i++)
            {
                for (int j = 0; j < Data.rows; j++)
                {
                    Arr[count] = saveGame[i, j];
                    count++;

                }
            }
            return Arr;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if(Data.startCheckerData == false)
            {
                MessageBox.Show("Прежде чем сохранить, начните игру", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrEmpty(tbSaveGame.Text) || String.IsNullOrWhiteSpace(tbSaveGame.Text))
            {
                MessageBox.Show("Вы не ввели имя!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var db = new LiteDatabase(@"GameDB.db"))
            {
                var Save_game = db.GetCollection<GameS>("save_games");
                var Game_saving = new GameS { };
                Game_saving.Name = tbSaveGame.Text;
                Game_saving.row = Data.rows;
                Game_saving.col = Data.cols;
                Game_saving.resolution = Data.resolutionData;
                Game_saving.Game_Zone = MatrixToArray();
                Save_game.Insert(Game_saving);
                tbSaveGame.Text = "";
                Hide();
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены?", "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.OK)
            {
                tbSaveGame.Text = "";
                Hide();
            }
        }
    }
}

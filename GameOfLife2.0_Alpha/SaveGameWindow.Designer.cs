
namespace GameOfLife2._0_Alpha
{
    partial class SaveGameWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveGameWindow));
            this.bSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSaveGame = new System.Windows.Forms.TextBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bSave
            // 
            this.bSave.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bSave.Location = new System.Drawing.Point(33, 71);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(107, 31);
            this.bSave.TabIndex = 0;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = false;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите имя сохранения";
            // 
            // tbSaveGame
            // 
            this.tbSaveGame.Location = new System.Drawing.Point(33, 45);
            this.tbSaveGame.Name = "tbSaveGame";
            this.tbSaveGame.Size = new System.Drawing.Size(223, 20);
            this.tbSaveGame.TabIndex = 2;
            this.tbSaveGame.TextChanged += new System.EventHandler(this.tbSaveGame_TextChanged);
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bCancel.Location = new System.Drawing.Point(149, 71);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(107, 31);
            this.bCancel.TabIndex = 3;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // SaveGameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(292, 122);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.tbSaveGame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(308, 161);
            this.MinimumSize = new System.Drawing.Size(308, 161);
            this.Name = "SaveGameWindow";
            this.Text = "Сохранить игру";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSaveGame;
        private System.Windows.Forms.Button bCancel;
    }
}
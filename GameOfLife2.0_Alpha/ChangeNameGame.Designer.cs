
namespace GameOfLife2._0_Alpha
{
    partial class ChangeNameGame
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
            this.bCancel = new System.Windows.Forms.Button();
            this.tbSaveGame = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bCancel.Location = new System.Drawing.Point(132, 71);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(107, 31);
            this.bCancel.TabIndex = 7;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = false;
            // 
            // tbSaveGame
            // 
            this.tbSaveGame.Location = new System.Drawing.Point(16, 45);
            this.tbSaveGame.Name = "tbSaveGame";
            this.tbSaveGame.Size = new System.Drawing.Size(223, 20);
            this.tbSaveGame.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите новое имя сохранения";
            // 
            // bSave
            // 
            this.bSave.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bSave.Location = new System.Drawing.Point(16, 71);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(107, 31);
            this.bSave.TabIndex = 4;
            this.bSave.Text = "Применить";
            this.bSave.UseVisualStyleBackColor = false;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // ChangeNameGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(252, 122);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.tbSaveGame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bSave);
            this.MaximumSize = new System.Drawing.Size(268, 161);
            this.MinimumSize = new System.Drawing.Size(268, 161);
            this.Name = "ChangeNameGame";
            this.Text = "Переименовать игру";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.TextBox tbSaveGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bSave;
    }
}
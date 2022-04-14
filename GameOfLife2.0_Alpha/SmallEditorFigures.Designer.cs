
namespace GameOfLife2._0_Alpha
{
    partial class SmallEditorFigures
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmallEditorFigures));
            this.bCansel = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.tbSaveGame = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbFigure = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFigure)).BeginInit();
            this.SuspendLayout();
            // 
            // bCansel
            // 
            this.bCansel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bCansel.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bCansel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCansel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bCansel.Location = new System.Drawing.Point(365, 169);
            this.bCansel.Name = "bCansel";
            this.bCansel.Size = new System.Drawing.Size(116, 23);
            this.bCansel.TabIndex = 26;
            this.bCansel.Text = "Отмена";
            this.bCansel.UseVisualStyleBackColor = false;
            this.bCansel.Click += new System.EventHandler(this.bCansel_Click);
            // 
            // bSave
            // 
            this.bSave.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bSave.Location = new System.Drawing.Point(243, 169);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(116, 23);
            this.bSave.TabIndex = 25;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = false;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bStart
            // 
            this.bStart.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bStart.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bStart.Location = new System.Drawing.Point(243, 112);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(96, 23);
            this.bStart.TabIndex = 24;
            this.bStart.Text = "Начать";
            this.bStart.UseVisualStyleBackColor = false;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // tbSaveGame
            // 
            this.tbSaveGame.Location = new System.Drawing.Point(243, 86);
            this.tbSaveGame.Name = "tbSaveGame";
            this.tbSaveGame.Size = new System.Drawing.Size(223, 20);
            this.tbSaveGame.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(240, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Введите имя фигуры";
            // 
            // pbFigure
            // 
            this.pbFigure.BackColor = System.Drawing.Color.Black;
            this.pbFigure.Location = new System.Drawing.Point(10, 12);
            this.pbFigure.Name = "pbFigure";
            this.pbFigure.Size = new System.Drawing.Size(227, 227);
            this.pbFigure.TabIndex = 19;
            this.pbFigure.TabStop = false;
            this.pbFigure.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbFigure_MouseMove_1);
            // 
            // SmallEditorFigures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(490, 251);
            this.Controls.Add(this.bCansel);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.tbSaveGame);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbFigure);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(506, 290);
            this.MinimumSize = new System.Drawing.Size(506, 290);
            this.Name = "SmallEditorFigures";
            this.Text = "Редактировать фигуру";
            this.Activated += new System.EventHandler(this.SmallEditorFigures_Activated_1);
            ((System.ComponentModel.ISupportInitialize)(this.pbFigure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCansel;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.TextBox tbSaveGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbFigure;
    }
}
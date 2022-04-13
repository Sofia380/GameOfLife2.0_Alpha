
namespace GameOfLife2._0_Alpha
{
    partial class CreateFigures
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateFigures));
            this.pbFigure = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbResolution = new System.Windows.Forms.TrackBar();
            this.tbSaveGame = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bStart = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFigure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbResolution)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFigure
            // 
            this.pbFigure.BackColor = System.Drawing.Color.Black;
            this.pbFigure.Location = new System.Drawing.Point(12, 12);
            this.pbFigure.Name = "pbFigure";
            this.pbFigure.Size = new System.Drawing.Size(227, 227);
            this.pbFigure.TabIndex = 1;
            this.pbFigure.TabStop = false;
            this.pbFigure.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbFigure_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(242, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Размер клеток";
            // 
            // tbResolution
            // 
            this.tbResolution.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbResolution.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbResolution.Location = new System.Drawing.Point(245, 58);
            this.tbResolution.Maximum = 30;
            this.tbResolution.Minimum = 5;
            this.tbResolution.Name = "tbResolution";
            this.tbResolution.Size = new System.Drawing.Size(182, 45);
            this.tbResolution.TabIndex = 11;
            this.tbResolution.Value = 5;
            // 
            // tbSaveGame
            // 
            this.tbSaveGame.Location = new System.Drawing.Point(245, 115);
            this.tbSaveGame.Name = "tbSaveGame";
            this.tbSaveGame.Size = new System.Drawing.Size(223, 20);
            this.tbSaveGame.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(242, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Введите имя фигуры";
            // 
            // bStart
            // 
            this.bStart.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bStart.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bStart.Location = new System.Drawing.Point(245, 141);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(96, 23);
            this.bStart.TabIndex = 16;
            this.bStart.Text = "Начать";
            this.bStart.UseVisualStyleBackColor = false;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bSave
            // 
            this.bSave.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bSave.Location = new System.Drawing.Point(245, 198);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(116, 23);
            this.bSave.TabIndex = 17;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = false;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bCancel.Location = new System.Drawing.Point(367, 198);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(116, 23);
            this.bCancel.TabIndex = 18;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // CreateFigures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(490, 251);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.tbSaveGame);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbResolution);
            this.Controls.Add(this.pbFigure);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(506, 290);
            this.MinimumSize = new System.Drawing.Size(506, 290);
            this.Name = "CreateFigures";
            this.Text = "Создать фигуру";
            ((System.ComponentModel.ISupportInitialize)(this.pbFigure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbResolution)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFigure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbResolution;
        private System.Windows.Forms.TextBox tbSaveGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bCancel;
    }
}
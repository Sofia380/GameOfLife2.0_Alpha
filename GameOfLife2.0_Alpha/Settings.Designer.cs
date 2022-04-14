
namespace GameOfLife2._0_Alpha
{
    partial class Settings
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
            this.rbDraw = new System.Windows.Forms.RadioButton();
            this.rbAuto = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDensity = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tbResolution = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bApply = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbDensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbResolution)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbDraw
            // 
            this.rbDraw.AutoSize = true;
            this.rbDraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbDraw.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbDraw.Location = new System.Drawing.Point(3, 30);
            this.rbDraw.Name = "rbDraw";
            this.rbDraw.Size = new System.Drawing.Size(117, 17);
            this.rbDraw.TabIndex = 8;
            this.rbDraw.Text = "Режим рисования";
            this.rbDraw.UseVisualStyleBackColor = true;
            this.rbDraw.CheckedChanged += new System.EventHandler(this.rbDraw_CheckedChanged);
            // 
            // rbAuto
            // 
            this.rbAuto.AutoSize = true;
            this.rbAuto.Checked = true;
            this.rbAuto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbAuto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbAuto.Location = new System.Drawing.Point(3, 3);
            this.rbAuto.Name = "rbAuto";
            this.rbAuto.Size = new System.Drawing.Size(75, 17);
            this.rbAuto.TabIndex = 7;
            this.rbAuto.TabStop = true;
            this.rbAuto.Text = "Авто игра";
            this.rbAuto.UseVisualStyleBackColor = true;
            this.rbAuto.CheckedChanged += new System.EventHandler(this.rbAuto_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Плотность заполнения";
            // 
            // tbDensity
            // 
            this.tbDensity.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbDensity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbDensity.Location = new System.Drawing.Point(12, 103);
            this.tbDensity.Maximum = 20;
            this.tbDensity.Minimum = 2;
            this.tbDensity.Name = "tbDensity";
            this.tbDensity.Size = new System.Drawing.Size(182, 45);
            this.tbDensity.TabIndex = 11;
            this.tbDensity.Value = 5;
            this.tbDensity.Scroll += new System.EventHandler(this.tbDensity_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Размер клеток";
            // 
            // tbResolution
            // 
            this.tbResolution.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbResolution.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbResolution.Location = new System.Drawing.Point(12, 32);
            this.tbResolution.Maximum = 25;
            this.tbResolution.Minimum = 2;
            this.tbResolution.Name = "tbResolution";
            this.tbResolution.Size = new System.Drawing.Size(182, 45);
            this.tbResolution.TabIndex = 9;
            this.tbResolution.Value = 2;
            this.tbResolution.Scroll += new System.EventHandler(this.tbResolution_Scroll);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbDraw);
            this.panel1.Controls.Add(this.rbAuto);
            this.panel1.Location = new System.Drawing.Point(220, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 52);
            this.panel1.TabIndex = 14;
            // 
            // bApply
            // 
            this.bApply.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bApply.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bApply.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bApply.Location = new System.Drawing.Point(220, 125);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(96, 23);
            this.bApply.TabIndex = 15;
            this.bApply.Text = "Применить";
            this.bApply.UseVisualStyleBackColor = false;
            this.bApply.Click += new System.EventHandler(this.bApply_Click);
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bCancel.Location = new System.Drawing.Point(326, 125);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(96, 23);
            this.bCancel.TabIndex = 16;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(433, 160);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bApply);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDensity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbResolution);
            this.MaximumSize = new System.Drawing.Size(449, 199);
            this.MinimumSize = new System.Drawing.Size(449, 199);
            this.Name = "Settings";
            this.Text = "Настройки";
            ((System.ComponentModel.ISupportInitialize)(this.tbDensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbResolution)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbDraw;
        private System.Windows.Forms.RadioButton rbAuto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbDensity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbResolution;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bApply;
        private System.Windows.Forms.Button bCancel;
    }
}
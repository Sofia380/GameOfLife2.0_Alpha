
namespace GameOfLife2._0_Alpha
{
    partial class GameField
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameField));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.консольToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкаИгровогоПроцессаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.темыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фигурыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.моиСохраненияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьИгруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.спарвкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bSettings = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bCreateFigure = new System.Windows.Forms.Button();
            this.bSaveGame = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bChooseSave = new System.Windows.Forms.Button();
            this.bChooseFigure = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bReset = new System.Windows.Forms.Button();
            this.bContinue = new System.Windows.Forms.Button();
            this.bStop = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.спарвкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1248, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.консольToolStripMenuItem,
            this.фигурыToolStripMenuItem,
            this.моиСохраненияToolStripMenuItem,
            this.сохранитьИгруToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // консольToolStripMenuItem
            // 
            this.консольToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкаИгровогоПроцессаToolStripMenuItem,
            this.темыToolStripMenuItem});
            this.консольToolStripMenuItem.Name = "консольToolStripMenuItem";
            this.консольToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.консольToolStripMenuItem.Text = "Настройки игры";
            // 
            // настройкаИгровогоПроцессаToolStripMenuItem
            // 
            this.настройкаИгровогоПроцессаToolStripMenuItem.Name = "настройкаИгровогоПроцессаToolStripMenuItem";
            this.настройкаИгровогоПроцессаToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.настройкаИгровогоПроцессаToolStripMenuItem.Text = "Настройка игрового процесса";
            this.настройкаИгровогоПроцессаToolStripMenuItem.Click += new System.EventHandler(this.настройкаИгровогоПроцессаToolStripMenuItem_Click);
            // 
            // темыToolStripMenuItem
            // 
            this.темыToolStripMenuItem.Name = "темыToolStripMenuItem";
            this.темыToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.темыToolStripMenuItem.Text = "Темы";
            this.темыToolStripMenuItem.Click += new System.EventHandler(this.темыToolStripMenuItem_Click);
            // 
            // фигурыToolStripMenuItem
            // 
            this.фигурыToolStripMenuItem.Name = "фигурыToolStripMenuItem";
            this.фигурыToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.фигурыToolStripMenuItem.Text = "Фигуры";
            this.фигурыToolStripMenuItem.Click += new System.EventHandler(this.фигурыToolStripMenuItem_Click);
            // 
            // моиСохраненияToolStripMenuItem
            // 
            this.моиСохраненияToolStripMenuItem.Name = "моиСохраненияToolStripMenuItem";
            this.моиСохраненияToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.моиСохраненияToolStripMenuItem.Text = "Мои сохранения";
            this.моиСохраненияToolStripMenuItem.Click += new System.EventHandler(this.моиСохраненияToolStripMenuItem_Click);
            // 
            // сохранитьИгруToolStripMenuItem
            // 
            this.сохранитьИгруToolStripMenuItem.Name = "сохранитьИгруToolStripMenuItem";
            this.сохранитьИгруToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.сохранитьИгруToolStripMenuItem.Text = "Сохранить игру";
            this.сохранитьИгруToolStripMenuItem.Click += new System.EventHandler(this.сохранитьИгруToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // спарвкаToolStripMenuItem
            // 
            this.спарвкаToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.спарвкаToolStripMenuItem.Name = "спарвкаToolStripMenuItem";
            this.спарвкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.спарвкаToolStripMenuItem.Text = "Спарвка";
            this.спарвкаToolStripMenuItem.Click += new System.EventHandler(this.спарвкаToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1248, 426);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.bSettings);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.bCreateFigure);
            this.panel1.Controls.Add(this.bSaveGame);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.bChooseSave);
            this.panel1.Controls.Add(this.bChooseFigure);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.bReset);
            this.panel1.Controls.Add(this.bContinue);
            this.panel1.Controls.Add(this.bStop);
            this.panel1.Controls.Add(this.bStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 37);
            this.panel1.TabIndex = 2;
            // 
            // bSettings
            // 
            this.bSettings.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bSettings.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bSettings.Location = new System.Drawing.Point(819, 8);
            this.bSettings.Name = "bSettings";
            this.bSettings.Size = new System.Drawing.Size(100, 23);
            this.bSettings.TabIndex = 9;
            this.bSettings.Text = "Настройки игры";
            this.bSettings.UseVisualStyleBackColor = false;
            this.bSettings.Click += new System.EventHandler(this.bSettings_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SlateGray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(809, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 22);
            this.panel4.TabIndex = 6;
            // 
            // bCreateFigure
            // 
            this.bCreateFigure.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bCreateFigure.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bCreateFigure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCreateFigure.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bCreateFigure.Location = new System.Drawing.Point(597, 8);
            this.bCreateFigure.Name = "bCreateFigure";
            this.bCreateFigure.Size = new System.Drawing.Size(100, 23);
            this.bCreateFigure.TabIndex = 8;
            this.bCreateFigure.Text = "Создать фигуру";
            this.bCreateFigure.UseVisualStyleBackColor = false;
            this.bCreateFigure.Click += new System.EventHandler(this.bCreateFigure_Click);
            // 
            // bSaveGame
            // 
            this.bSaveGame.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bSaveGame.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bSaveGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSaveGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bSaveGame.Location = new System.Drawing.Point(703, 8);
            this.bSaveGame.Name = "bSaveGame";
            this.bSaveGame.Size = new System.Drawing.Size(100, 23);
            this.bSaveGame.TabIndex = 7;
            this.bSaveGame.Text = "Сохранить игру";
            this.bSaveGame.UseVisualStyleBackColor = false;
            this.bSaveGame.Click += new System.EventHandler(this.bSaveGame_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SlateGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(587, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 22);
            this.panel3.TabIndex = 5;
            // 
            // bChooseSave
            // 
            this.bChooseSave.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bChooseSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bChooseSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bChooseSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bChooseSave.Location = new System.Drawing.Point(458, 8);
            this.bChooseSave.Name = "bChooseSave";
            this.bChooseSave.Size = new System.Drawing.Size(123, 23);
            this.bChooseSave.TabIndex = 6;
            this.bChooseSave.Text = "Выбрать сохранение";
            this.bChooseSave.UseVisualStyleBackColor = false;
            this.bChooseSave.Click += new System.EventHandler(this.bChooseSave_Click);
            // 
            // bChooseFigure
            // 
            this.bChooseFigure.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bChooseFigure.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bChooseFigure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bChooseFigure.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bChooseFigure.Location = new System.Drawing.Point(352, 8);
            this.bChooseFigure.Name = "bChooseFigure";
            this.bChooseFigure.Size = new System.Drawing.Size(100, 23);
            this.bChooseFigure.TabIndex = 5;
            this.bChooseFigure.Text = "Выбрать фигуру";
            this.bChooseFigure.UseVisualStyleBackColor = false;
            this.bChooseFigure.Click += new System.EventHandler(this.bChooseFigure_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(342, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 22);
            this.panel2.TabIndex = 4;
            // 
            // bReset
            // 
            this.bReset.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bReset.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bReset.Location = new System.Drawing.Point(261, 8);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(75, 23);
            this.bReset.TabIndex = 3;
            this.bReset.Text = "Сброс";
            this.bReset.UseVisualStyleBackColor = false;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // bContinue
            // 
            this.bContinue.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bContinue.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bContinue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bContinue.Location = new System.Drawing.Point(174, 8);
            this.bContinue.Name = "bContinue";
            this.bContinue.Size = new System.Drawing.Size(81, 23);
            this.bContinue.TabIndex = 2;
            this.bContinue.Text = "Продолжить";
            this.bContinue.UseVisualStyleBackColor = false;
            this.bContinue.Click += new System.EventHandler(this.bContinue_Click);
            // 
            // bStop
            // 
            this.bStop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bStop.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bStop.Location = new System.Drawing.Point(93, 8);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(75, 23);
            this.bStop.TabIndex = 1;
            this.bStop.Text = "Стоп";
            this.bStop.UseVisualStyleBackColor = false;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // bStart
            // 
            this.bStart.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bStart.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bStart.Location = new System.Drawing.Point(12, 8);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(75, 23);
            this.bStart.TabIndex = 0;
            this.bStart.Text = "Старт";
            this.bStart.UseVisualStyleBackColor = false;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GameField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GameField";
            this.Text = "Game of Life 2.0 Alpfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem консольToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фигурыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьИгруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem спарвкаToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Button bContinue;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bCreateFigure;
        private System.Windows.Forms.Button bSaveGame;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bChooseSave;
        private System.Windows.Forms.Button bChooseFigure;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bSettings;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStripMenuItem моиСохраненияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкаИгровогоПроцессаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem темыToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}


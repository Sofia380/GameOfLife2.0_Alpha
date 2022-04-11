
namespace GameOfLife2._0_Alpha
{
    partial class EditorGame
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbFiguresEditor = new System.Windows.Forms.ListBox();
            this.bDelet = new System.Windows.Forms.Button();
            this.bChangeName = new System.Windows.Forms.Button();
            this.bUse = new System.Windows.Forms.Button();
            this.pbFigure = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.использоватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.переименоватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFigure)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbFiguresEditor);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainer1.Panel2.Controls.Add(this.bDelet);
            this.splitContainer1.Panel2.Controls.Add(this.bChangeName);
            this.splitContainer1.Panel2.Controls.Add(this.bUse);
            this.splitContainer1.Panel2.Controls.Add(this.pbFigure);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 566;
            this.splitContainer1.TabIndex = 2;
            // 
            // lbFiguresEditor
            // 
            this.lbFiguresEditor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbFiguresEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbFiguresEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFiguresEditor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbFiguresEditor.FormattingEnabled = true;
            this.lbFiguresEditor.ItemHeight = 24;
            this.lbFiguresEditor.Location = new System.Drawing.Point(0, 0);
            this.lbFiguresEditor.Name = "lbFiguresEditor";
            this.lbFiguresEditor.Size = new System.Drawing.Size(566, 450);
            this.lbFiguresEditor.TabIndex = 0;
            this.lbFiguresEditor.SelectedIndexChanged += new System.EventHandler(this.lbFiguresEditor_SelectedIndexChanged);
            this.lbFiguresEditor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbFiguresEditor_MouseUp);
            // 
            // bDelet
            // 
            this.bDelet.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bDelet.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bDelet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDelet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bDelet.Location = new System.Drawing.Point(35, 370);
            this.bDelet.Name = "bDelet";
            this.bDelet.Size = new System.Drawing.Size(159, 31);
            this.bDelet.TabIndex = 7;
            this.bDelet.Text = "Удалить";
            this.bDelet.UseVisualStyleBackColor = false;
            // 
            // bChangeName
            // 
            this.bChangeName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bChangeName.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bChangeName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bChangeName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bChangeName.Location = new System.Drawing.Point(35, 333);
            this.bChangeName.Name = "bChangeName";
            this.bChangeName.Size = new System.Drawing.Size(159, 31);
            this.bChangeName.TabIndex = 6;
            this.bChangeName.Text = "Переименовать";
            this.bChangeName.UseVisualStyleBackColor = false;
            this.bChangeName.Click += new System.EventHandler(this.bChangeName_Click);
            // 
            // bUse
            // 
            this.bUse.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bUse.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bUse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bUse.Location = new System.Drawing.Point(35, 296);
            this.bUse.Name = "bUse";
            this.bUse.Size = new System.Drawing.Size(159, 31);
            this.bUse.TabIndex = 4;
            this.bUse.Text = "Использовать";
            this.bUse.UseVisualStyleBackColor = false;
            this.bUse.Click += new System.EventHandler(this.bUse_Click);
            // 
            // pbFigure
            // 
            this.pbFigure.BackColor = System.Drawing.Color.Black;
            this.pbFigure.Location = new System.Drawing.Point(0, 3);
            this.pbFigure.Name = "pbFigure";
            this.pbFigure.Size = new System.Drawing.Size(227, 227);
            this.pbFigure.TabIndex = 0;
            this.pbFigure.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.использоватьToolStripMenuItem,
            this.toolStripSeparator1,
            this.переименоватьToolStripMenuItem1,
            this.toolStripSeparator2,
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(162, 82);
            // 
            // использоватьToolStripMenuItem
            // 
            this.использоватьToolStripMenuItem.Name = "использоватьToolStripMenuItem";
            this.использоватьToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.использоватьToolStripMenuItem.Text = "Использовать";
            this.использоватьToolStripMenuItem.Click += new System.EventHandler(this.использоватьToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
            // 
            // переименоватьToolStripMenuItem1
            // 
            this.переименоватьToolStripMenuItem1.Name = "переименоватьToolStripMenuItem1";
            this.переименоватьToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.переименоватьToolStripMenuItem1.Text = "Переименовать";
            this.переименоватьToolStripMenuItem1.Click += new System.EventHandler(this.переименоватьToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(158, 6);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // EditorGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "EditorGame";
            this.Text = "Сохраненные игры";
            this.Activated += new System.EventHandler(this.EditorGame_Activated);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFigure)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lbFiguresEditor;
        private System.Windows.Forms.Button bDelet;
        private System.Windows.Forms.Button bChangeName;
        private System.Windows.Forms.Button bUse;
        private System.Windows.Forms.PictureBox pbFigure;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem использоватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem переименоватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
    }
}
namespace lab_19
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            showImageToolStripMenuItem = new ToolStripMenuItem();
            clearImageToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.Font = new Font("Lobster", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { showImageToolStripMenuItem, clearImageToolStripMenuItem, quitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1006, 38);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // showImageToolStripMenuItem
            // 
            showImageToolStripMenuItem.Name = "showImageToolStripMenuItem";
            showImageToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.D1;
            showImageToolStripMenuItem.Size = new Size(199, 34);
            showImageToolStripMenuItem.Text = "Вивід зображення";
            showImageToolStripMenuItem.Click += showImageToolStripMenuItem_Click;
            // 
            // clearImageToolStripMenuItem
            // 
            clearImageToolStripMenuItem.Name = "clearImageToolStripMenuItem";
            clearImageToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.D2;
            clearImageToolStripMenuItem.Size = new Size(243, 34);
            clearImageToolStripMenuItem.Text = "Очищення зображення";
            clearImageToolStripMenuItem.Click += clearImageToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.D3;
            quitToolStripMenuItem.Size = new Size(192, 34);
            quitToolStripMenuItem.Text = "Вихід з програми";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 793);
            Controls.Add(menuStrip1);
            Font = new Font("Lobster", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Пейзажик)))";
            Paint += MainForm_Paint;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem showImageToolStripMenuItem;
        private ToolStripMenuItem clearImageToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
    }
}
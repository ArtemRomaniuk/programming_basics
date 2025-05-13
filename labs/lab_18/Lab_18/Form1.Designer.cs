namespace Lab_18
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            sizeToolStripMenuItem = new ToolStripMenuItem();
            resultToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            perimeterLabel = new Label();
            areaLabel = new Label();
            perimeterValueLabel = new Label();
            areaValueLabel = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { sizeToolStripMenuItem, resultToolStripMenuItem, quitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(317, 36);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // sizeToolStripMenuItem
            // 
            sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            sizeToolStripMenuItem.Size = new Size(62, 32);
            sizeToolStripMenuItem.Text = "Size";
            sizeToolStripMenuItem.Click += sizeToolStripMenuItem_Click;
            // 
            // resultToolStripMenuItem
            // 
            resultToolStripMenuItem.Name = "resultToolStripMenuItem";
            resultToolStripMenuItem.Size = new Size(81, 32);
            resultToolStripMenuItem.Text = "Result";
            resultToolStripMenuItem.Click += resultToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(65, 32);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // perimeterLabel
            // 
            perimeterLabel.AutoSize = true;
            perimeterLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            perimeterLabel.Location = new Point(12, 62);
            perimeterLabel.Name = "perimeterLabel";
            perimeterLabel.Size = new Size(221, 25);
            perimeterLabel.TabIndex = 1;
            perimeterLabel.Text = "Периметр прямокутника:";
            perimeterLabel.Visible = false;
            // 
            // areaLabel
            // 
            areaLabel.AutoSize = true;
            areaLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            areaLabel.Location = new Point(12, 104);
            areaLabel.Name = "areaLabel";
            areaLabel.Size = new Size(195, 25);
            areaLabel.TabIndex = 1;
            areaLabel.Text = "Площа прямокутника:";
            areaLabel.Visible = false;
            // 
            // perimeterValueLabel
            // 
            perimeterValueLabel.AutoSize = true;
            perimeterValueLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            perimeterValueLabel.Location = new Point(239, 62);
            perimeterValueLabel.Name = "perimeterValueLabel";
            perimeterValueLabel.Size = new Size(65, 25);
            perimeterValueLabel.TabIndex = 1;
            perimeterValueLabel.Text = "перим";
            perimeterValueLabel.Visible = false;
            // 
            // areaValueLabel
            // 
            areaValueLabel.AutoSize = true;
            areaValueLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            areaValueLabel.Location = new Point(239, 104);
            areaValueLabel.Name = "areaValueLabel";
            areaValueLabel.Size = new Size(66, 25);
            areaValueLabel.TabIndex = 1;
            areaValueLabel.Text = "площа";
            areaValueLabel.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(317, 165);
            Controls.Add(areaLabel);
            Controls.Add(areaValueLabel);
            Controls.Add(perimeterValueLabel);
            Controls.Add(perimeterLabel);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = "ФІТ, Романюк Артем, 2-ІПЗ";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sizeToolStripMenuItem;
        private ToolStripMenuItem resultToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private Label perimeterLabel;
        private Label areaLabel;
        private Label perimeterValueLabel;
        private Label areaValueLabel;
    }
}

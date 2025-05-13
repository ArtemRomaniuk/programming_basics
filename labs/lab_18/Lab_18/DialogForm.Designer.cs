namespace Lab_18
{
    partial class DialogForm
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
            label1 = new Label();
            rectangleWidthTextBox = new TextBox();
            label2 = new Label();
            rectangleHeightTextBox = new TextBox();
            perimeterCheckBox = new CheckBox();
            areaCheckBox = new CheckBox();
            label3 = new Label();
            label4 = new Label();
            calculateButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 79);
            label1.Name = "label1";
            label1.Size = new Size(176, 20);
            label1.TabIndex = 0;
            label1.Text = "Довжина прямокутника";
            // 
            // rectangleWidthTextBox
            // 
            rectangleWidthTextBox.Location = new Point(194, 76);
            rectangleWidthTextBox.Name = "rectangleWidthTextBox";
            rectangleWidthTextBox.Size = new Size(187, 27);
            rectangleWidthTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 121);
            label2.Name = "label2";
            label2.Size = new Size(170, 20);
            label2.TabIndex = 0;
            label2.Text = "Ширина прямокутника";
            // 
            // rectangleHeightTextBox
            // 
            rectangleHeightTextBox.Location = new Point(194, 118);
            rectangleHeightTextBox.Name = "rectangleHeightTextBox";
            rectangleHeightTextBox.Size = new Size(187, 27);
            rectangleHeightTextBox.TabIndex = 1;
            // 
            // perimeterCheckBox
            // 
            perimeterCheckBox.AutoSize = true;
            perimeterCheckBox.Location = new Point(194, 170);
            perimeterCheckBox.Name = "perimeterCheckBox";
            perimeterCheckBox.Size = new Size(102, 24);
            perimeterCheckBox.TabIndex = 2;
            perimeterCheckBox.Text = "Периметр";
            perimeterCheckBox.UseVisualStyleBackColor = true;
            // 
            // areaCheckBox
            // 
            areaCheckBox.AutoSize = true;
            areaCheckBox.Location = new Point(302, 171);
            areaCheckBox.Name = "areaCheckBox";
            areaCheckBox.Size = new Size(79, 24);
            areaCheckBox.TabIndex = 2;
            areaCheckBox.Text = "Площа";
            areaCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 27);
            label3.Name = "label3";
            label3.Size = new Size(387, 25);
            label3.TabIndex = 0;
            label3.Text = "Обчислення характеристик прямокутника";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 172);
            label4.Name = "label4";
            label4.Size = new Size(171, 20);
            label4.TabIndex = 0;
            label4.Text = "Вкажіть, що обчислити:";
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(117, 210);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(149, 41);
            calculateButton.TabIndex = 3;
            calculateButton.Text = "Обчислити";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // DialogForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 263);
            Controls.Add(calculateButton);
            Controls.Add(areaCheckBox);
            Controls.Add(perimeterCheckBox);
            Controls.Add(rectangleHeightTextBox);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(rectangleWidthTextBox);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "DialogForm";
            Text = "Прямокутник";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox rectangleWidthTextBox;
        private Label label2;
        private TextBox rectangleHeightTextBox;
        private CheckBox perimeterCheckBox;
        private CheckBox areaCheckBox;
        private Label label3;
        private Label label4;
        private Button calculateButton;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_18
{
    public partial class DialogForm : Form
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int RectanglePerimeter { get; private set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int RectangleArea { get; private set; }
        public DialogForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(rectangleWidthTextBox.Text, out int parsedWidth) && int.TryParse(rectangleHeightTextBox.Text, out int parsedHeight) 
                && (parsedWidth > 0 && parsedHeight > 0))
            {
                int perimeter = (parsedHeight + parsedWidth) * 2;
                int area = parsedWidth * parsedHeight;
                if (!perimeterCheckBox.Checked && !areaCheckBox.Checked)
                {
                    MessageBox.Show(
                    "Позначте, що потрібно вираховувати за допомогою прапорців",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1
                    );
                } else 
                {
                    if (perimeterCheckBox.Checked) RectanglePerimeter = perimeter;
                    if (areaCheckBox.Checked) RectangleArea = area;
                    this.Close();
                }
            } else
            {
                MessageBox.Show(
                    "Введіть цілі ДОДАТНІ числа в поля довжин прямокутника",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1
                    );
            }
        }
        public bool isAreaCheckBoxChecked() { return areaCheckBox.Checked; }
        public bool isPerimeterCheckBoxChecked() { return perimeterCheckBox.Checked; }
    }
}
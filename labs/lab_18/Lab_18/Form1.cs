namespace Lab_18
{
    public partial class MainForm : Form
    {
        private DialogForm dialogForm = new DialogForm();
        private Point origAreaLabelLocation;
        private Point origAreaValueLabelLocation;
        public MainForm()
        {
            InitializeComponent();
            origAreaLabelLocation = this.areaLabel.Location;
            origAreaValueLabelLocation = this.areaValueLabel.Location;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogForm.ShowDialog();
        }

        private void resultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int area = dialogForm.RectangleArea;
            int perimeter = dialogForm.RectanglePerimeter;
            
            if (area != 0 || perimeter != 0)
            {
                if (dialogForm.isAreaCheckBoxChecked() && dialogForm.isPerimeterCheckBoxChecked())
                {
                    perimeterLabel.Visible = true;
                    perimeterValueLabel.Visible = true;
                    perimeterValueLabel.Text = perimeter.ToString();

                    areaLabel.Location = origAreaLabelLocation;
                    areaLabel.Visible = true;
                    areaValueLabel.Location = origAreaValueLabelLocation;
                    areaValueLabel.Visible = true;
                    areaValueLabel.Text = area.ToString();

                } else if (dialogForm.isPerimeterCheckBoxChecked())
                {
                    perimeterLabel.Visible = true;
                    perimeterValueLabel.Visible = true;
                    perimeterValueLabel.Text = perimeter.ToString();

                    areaLabel.Visible = false;
                    areaValueLabel.Visible = false;

                } else if (dialogForm.isAreaCheckBoxChecked())
                {
                    areaLabel.Location = new Point(perimeterLabel.Location.X, perimeterLabel.Location.Y);
                    areaLabel.Visible = true;
                    areaValueLabel.Location = new Point(perimeterValueLabel.Location.X, perimeterValueLabel.Location.Y);
                    areaValueLabel.Visible = true;
                    areaValueLabel.Text = area.ToString();

                    perimeterLabel.Visible = false;
                    perimeterValueLabel.Visible = false;
                }
            } else
            {
                MessageBox.Show(
                    "Скористайтесь функцією \"Size\"",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1
                    );
            }
        }
    }
}

using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab_19_WPF_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            if(clearRectangle.Visibility == Visibility.Collapsed) clearRectangle.Visibility = Visibility.Visible;
        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            if (clearRectangle.Visibility == Visibility.Visible) clearRectangle.Visibility = Visibility.Collapsed;
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.D1) ShowButton_Click(null, null);
            else if (e.Key == Key.D2) ClearButton_Click(null, null);
            else if (e.Key == Key.D3) ExitButton_Click(null, null);
            else if (e.Key == Key.D4) AnimateBunnyButton_Click(null, null);
        }

        private bool isAnimateBunnySubscribed = false;
        private double angle = 0;
        private double amplitude = 50;
        private double dAngle = 2;

        private void AnimateBunnyButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isAnimateBunnySubscribed)
            {
                isAnimateBunnySubscribed = true;
                CompositionTarget.Rendering += AnimateBunny;
            }
        }

        private void AnimateBunny(object sender, EventArgs e)
        {
            double y = amplitude * Math.Sin(angle * Math.PI / 180);

            CanvasTransform.Y = y;
            CanvasTransform.X = angle;

            angle += dAngle;

            if (angle == 450)
            {
                CompositionTarget.Rendering -= AnimateBunny;
                CanvasTransform.X = 0;
                CanvasTransform.Y = 0;
                angle = 0;
                isAnimateBunnySubscribed = false;
            }
            
        }
    }
}
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace RunningButton
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btN_MouseEnter(object sender, MouseEventArgs e)
        {
            Random random = new Random();
            int x = random.Next(-100, 100);
            int y = random.Next(-100, 100);
            int z = random.Next(-100, 100);
            int q = random.Next(-100, 100);
            DoubleAnimation buttonAnimation = new DoubleAnimation();
            var animation = new ThicknessAnimation
            {
                By = new Thickness(x, y, z, q),
                Duration = TimeSpan.FromSeconds(0.1)
            };
            btN.BeginAnimation(MarginProperty, animation);
        }

        private void btN_MouseLeave(object sender, MouseEventArgs e)
        {

        }
    }
}

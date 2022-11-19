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
        /// <summary>
        /// The x
        /// </summary>
        int x;
        /// <summary>
        /// The y
        /// </summary>
        int y;
        /// <summary>
        /// The z
        /// </summary>
        int z;
        /// <summary>
        /// The q
        /// </summary>
        int q;

        /// <summary>The flag</summary>
        private bool flag;
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the MouseEnter event of the btN control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void BtN_MouseEnter(object sender, MouseEventArgs e)
        {
            if (flag)
            {
                flag = false;
                var random = new Random();
                x = random.Next(-300, 300);
                y = 0;
                z = random.Next(-300, 300);
                q = 0;
                var animation = new ThicknessAnimation
                {
                    By = new Thickness(x, y, z, q),
                    Duration = TimeSpan.FromSeconds(1)
                };
                btN.BeginAnimation(MarginProperty, animation);
            }
        }

        /// <summary>
        /// Handles the MouseLeave event of the btN control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void btN_MouseLeave(object sender, MouseEventArgs e)
        {
            if (!flag)
            {
                flag = true;
                var animation = new ThicknessAnimation
                {
                    By = new Thickness(-x, -y, -z, -q),
                    Duration = TimeSpan.FromSeconds(1)
                };
                btN.BeginAnimation(MarginProperty, animation);
            }
        }
    }
}

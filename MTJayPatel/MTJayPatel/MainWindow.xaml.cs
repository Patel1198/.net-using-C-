using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MTJayPatel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// For Menubar: https://www.wpf-tutorial.com/common-interface-controls/menu-control/
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnHockey_Click(object sender, RoutedEventArgs e)
        {
            ViewHockeyPlayer viewHockeyPlayer = new ViewHockeyPlayer();
            viewHockeyPlayer.ShowDialog();
            
            
        }

        private void btnBasketball_Click(object sender, RoutedEventArgs e)
        {
            ViewBasketballPlayer viewBasketballPlayer = new ViewBasketballPlayer();
            viewBasketballPlayer.ShowDialog();
            
        }

        private void btnBaseball_Click(object sender, RoutedEventArgs e)
        {
            ViewBaseballPlayer viewBaseballPlayer = new ViewBaseballPlayer();
            viewBaseballPlayer.ShowDialog();
            

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Do You Really Want to Close This Window?", "Exit", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                MessageBox.Show("Application Window is Successfully Closed.", "Confirmation", MessageBoxButton.OK, MessageBoxImage.Information);
                Environment.Exit(0);

            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnHelp_Click(object sender, RoutedEventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
    }
}

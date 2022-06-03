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

namespace Personal.BoardGame.Wpf
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

        public int PlayerMarginUp = 0;
        public int PlayerMarginLeft = 0;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void BtnUp_Click(object sender, RoutedEventArgs e)
        {
            MoveUp();
        }

        private void BtnLeft_Click(object sender, RoutedEventArgs e)
        {
            MoveLeft();
        }

        private void BtnDown_Click(object sender, RoutedEventArgs e)
        {
            MoveDown();
        }

        private void BtnRight_Click(object sender, RoutedEventArgs e)
        {
            MoveRight();
        }

        private void MoveUp()
        {
            if (PlayerMarginUp >= 30)
            {
                PlayerMarginUp -= 30;
            }
            UpdateLblPlayer();
        }

        private void MoveLeft()
        {
            if (PlayerMarginLeft >= 30)
            {
                PlayerMarginLeft -= 30;
            }
            UpdateLblPlayer();
        }

        private void MoveDown()
        {
            if (PlayerMarginUp <= 480)
            {
                PlayerMarginUp += 30;
            }
            UpdateLblPlayer();
        }

        private void MoveRight()
        {
            if (PlayerMarginLeft <= 480)
            {
                PlayerMarginLeft += 30;
            }
            UpdateLblPlayer();
        }

        private void UpdateLblPlayer()
        {
            lblPlayer.Margin = new Thickness(PlayerMarginLeft, PlayerMarginUp, 0, 0);
        }
    }
}

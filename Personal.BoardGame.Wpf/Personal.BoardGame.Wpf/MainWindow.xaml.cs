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

        public int PlayerMarginUp = 150;
        public int PlayerMarginLeft = 150;

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
            if (PlayerMarginUp != 30)
            {
                PlayerMarginUp -= 60;
            }
            UpdateLblPlayer();
        }

        private void MoveLeft()
        {
            if (PlayerMarginLeft != 30)
            {
                PlayerMarginLeft -= 60;
            }
            UpdateLblPlayer();
        }

        private void MoveDown()
        {
            if (PlayerMarginUp != 270)
            {
                PlayerMarginUp += 60;
            }
            UpdateLblPlayer();
        }

        private void MoveRight()
        {
            if (PlayerMarginLeft != 270)
            {
                PlayerMarginLeft += 60;
            }
            UpdateLblPlayer();
        }

        private void UpdateLblPlayer()
        {
            lblPlayer.Margin = new Thickness(PlayerMarginLeft, PlayerMarginUp, 0, 0);
        }
    }
}

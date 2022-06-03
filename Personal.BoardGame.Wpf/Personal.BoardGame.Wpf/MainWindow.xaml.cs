using Personal.BoardGame.Core.Entities;
using Personal.BoardGame.Core.Services;
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
        BoardGameService game = new BoardGameService();
        //Random random = new Random();
        Player moveablePlayer = new Player();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCreateNonTraversable_Click(object sender, RoutedEventArgs e)
        {
            game.CreateNonTraversables();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Startup();
        }

        private void BtnUp_Click(object sender, RoutedEventArgs e)
        {
            bool horizontal = false;
            bool toOrigin = true;
            PushPlayer(horizontal, toOrigin);
        }

        private void BtnLeft_Click(object sender, RoutedEventArgs e)
        {
            bool horizontal = true;
            bool toOrigin = true;
            PushPlayer(horizontal, toOrigin);
        }

        private void BtnDown_Click(object sender, RoutedEventArgs e)
        {
            bool horizontal = false;
            bool toOrigin = false;
            PushPlayer(horizontal, toOrigin);
        }

        private void BtnRight_Click(object sender, RoutedEventArgs e)
        {
            bool horizontal = true;
            bool toOrigin = false;
            PushPlayer(horizontal, toOrigin);
        }
        private void Startup()
        {
            SetPlayer();
        }
        private void SetPlayer()
        {
            int playerMarginLeft = moveablePlayer.SetHorizontal();
            int playerMarginTop = moveablePlayer.SetVertical();
            UpdateLblPlayer(playerMarginLeft, playerMarginTop);
        }

        private void PushPlayer(bool horizontal, bool toOrigin)
        {
            int playerMarginLeft;
            int playerMarginTop;
            int newValue = moveablePlayer.Move(horizontal, toOrigin);
            if (horizontal == true)
            {
                playerMarginLeft = newValue;
                playerMarginTop = (int)lblPlayer.Margin.Top;
                UpdateLblPlayer(playerMarginLeft, playerMarginTop);
            }
            else
            {
                playerMarginLeft = (int)lblPlayer.Margin.Left;
                playerMarginTop = newValue;
                UpdateLblPlayer(playerMarginLeft, playerMarginTop);
            }
        }

        private void UpdateLblPlayer(int playerMarginLeft, int playerMarginUp)
        {
            lblPlayer.Margin = new Thickness(playerMarginLeft, playerMarginUp, 0, 0);
        }
    }
}

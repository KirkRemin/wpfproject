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

namespace SlotGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Variables
        int playerDollars = 0;
        Random rand;
        int wheel1;
        int wheel2;
        int wheel3;
        Boolean wheel1Clicked = false;
        Boolean wheel2Clicked = false;
        Boolean wheel3Clicked = false;
       
        #endregion
        public MainWindow()
        {
            InitializeComponent();
            rand = new Random(DateTime.Now.Millisecond);
            imageWheel1.Source = new BitmapImage(new Uri("heart.png", UriKind.RelativeOrAbsolute));
            imageWheel2.Source = new BitmapImage(new Uri("heart.png", UriKind.RelativeOrAbsolute));
            imageWheel3.Source = new BitmapImage(new Uri("heart.png", UriKind.RelativeOrAbsolute));
            buttonPlay.Visibility = Visibility.Collapsed;


        }

        private void ButtonAddCash_Click(object sender, RoutedEventArgs e)
        {
            playerDollars += 10;
            textBlockDollars.Text = $"You have ${playerDollars}.";
            if(playerDollars > 0)
            {
                buttonPlay.Visibility = Visibility.Visible;
            }


        }

        private void ButtonPlay_Click(object sender, RoutedEventArgs e)
        {
            if (playerDollars > 0)
            {
                wheel1Clicked = false;
                wheel2Clicked = false;
                wheel3Clicked = false;
                playerDollars -= 1;
                textBlockDollars.Text = $"You have ${playerDollars}.";
                wheel1 = rand.Next(1, 7);
                wheel2 = rand.Next(1, 7);
                wheel3 = rand.Next(1, 7);
                buttonPlay.Content = $"You Spun A {wheel1}, {wheel2}, {wheel3}";
                if (wheel1Clicked == false) { spin(wheel1, imageWheel1); }
                if (wheel2Clicked == false) { spin(wheel2, imageWheel2); }
                if (wheel3Clicked == false) { spin(wheel3, imageWheel3); }
                imageWinLose.Source = new BitmapImage(new Uri("winGame.png", UriKind.RelativeOrAbsolute));
                Calculate_Win(wheel1, wheel2, wheel3);
            }
            else
            {
                imageWheel1.Opacity = 0.1f;
                imageWheel2.Opacity = 0.1f;
                imageWheel3.Opacity = 0.1f;
                buttonPlay.Visibility = Visibility.Collapsed;
            }
        }
        public void spin(int wheel, Image imageBox)
        {
            imageBox.Opacity = 1f;
            if (wheel == 1) { imageBox.Source = new BitmapImage(new Uri("Images/lose.png", UriKind.RelativeOrAbsolute)); }
            else if (wheel == 2) {imageBox.Source = new BitmapImage(new Uri("Images/spade.png", UriKind.RelativeOrAbsolute)); }
            else if (wheel == 3) { imageBox.Source = new BitmapImage(new Uri("Images/club.png", UriKind.RelativeOrAbsolute)); }
            else if (wheel == 4) { imageBox.Source = new BitmapImage(new Uri("Images/heart.png", UriKind.RelativeOrAbsolute)); }
            else if (wheel == 5) { imageBox.Source = new BitmapImage(new Uri("Images/diamond.png", UriKind.RelativeOrAbsolute)); }
            else imageBox.Source = new BitmapImage(new Uri("Images/win.png", UriKind.RelativeOrAbsolute));
        }

        private void ImageWheel1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (playerDollars >= 20)
            {
                if (wheel1Clicked == false)
                {
                    wheel1Clicked = true;
                    imageWheel1.Opacity = 0.6f;
                    playerDollars -= 20;
                }
                else
                {
                    wheel1Clicked = false;
                    imageWheel1.Opacity = 1f;
                }
            }
        }

        private void ImageWheel2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (playerDollars >= 20)
            {
                if (wheel2Clicked == false)
                {
                    wheel2Clicked = true;
                    imageWheel2.Opacity = 0.6f;
                    playerDollars -= 20;
                }
                else
                {
                    wheel2Clicked = false;
                    imageWheel2.Opacity = 1f;
                }
            }
        }

        private void Calculate_Win(int slot1, int slot2, int slot3)
        {
            if ((slot1 == 1) || (slot2 == 1) || (slot3 == 1))
            {
                playerDollars -= 2;
            }
            else
            {
                for (int i = 2; i <= 6; i++)
                {
                    if ((slot1 == i) && (slot2 == i) && (slot3 == i))
                    {
                        playerDollars += (i * 10);
                        imageWinLose.Source = new BitmapImage(new Uri("Images/winGame.png", UriKind.RelativeOrAbsolute));
                    }
                }
                for (int i = 2; i <= 5; i++)
                {
                    if ((slot1 == i) && (slot2 == i) && (slot3 == 6))
                    {
                        playerDollars += (i * 2);
                        imageWinLose.Source = new BitmapImage(new Uri("Images/winGame.png", UriKind.RelativeOrAbsolute));
                    }
                    else if ((slot1 == 6) && (slot2 == i) && (slot3 == i))
                    {
                        playerDollars += (i * 2);
                        imageWinLose.Source = new BitmapImage(new Uri("Images/winGame.png", UriKind.RelativeOrAbsolute));
                    }
                    else if ((slot1 == i) && (slot2 == 6) && (slot3 == i))
                    {
                        playerDollars += (i * 2);
                        imageWinLose.Source = new BitmapImage(new Uri("Images/winGame.png", UriKind.RelativeOrAbsolute));
                    }
                }
            }
            
        }

        private void ImageWheel3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (playerDollars >= 20)
            {
                if (wheel3Clicked == false)
                {
                    wheel3Clicked = true;
                    imageWheel3.Opacity = 0.6f;
                    playerDollars -= 20;
                }
                else
                {
                    wheel3Clicked = false;
                    imageWheel3.Opacity = 1f;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BetterSlotMachine window2 = new BetterSlotMachine();
            window2.Show();
            Close();
        }
    }
}

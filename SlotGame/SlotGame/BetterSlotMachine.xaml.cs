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
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SlotGame
{
    /// <summary>
    /// Interaction logic for BetterSlotMachine.xaml
    /// </summary>
    public partial class BetterSlotMachine : Window
    {
        #region Variables
        Image[,] slotReelImages = new Image[3, 5];
        Random random = new Random(DateTime.Now.Millisecond);
        SlotWheel Slots;
        int playerDollars = 0;
        int playerBet = 0;
        
        #endregion
        public BetterSlotMachine()
        {
            
            InitializeComponent();
            #region ImageArray
            slotReelImages[0, 0] = imageB0;
            slotReelImages[0, 1] = imageB1;
            slotReelImages[0, 2] = imageB2;
            slotReelImages[0, 3] = imageB3;
            slotReelImages[0, 4] = imageB4;
            slotReelImages[1, 0] = imageC0;
            slotReelImages[1, 1] = imageC1;
            slotReelImages[1, 2] = imageC2;
            slotReelImages[1, 3] = imageC3;
            slotReelImages[1, 4] = imageC4;
            slotReelImages[2, 0] = imageD0;
            slotReelImages[2, 1] = imageD1;
            slotReelImages[2, 2] = imageD2;
            slotReelImages[2, 3] = imageD3;
            slotReelImages[2, 4] = imageD4;
            #endregion
            #region Initializing Variables
            Slots = new SlotWheel(random);
            #endregion
            #region Initializing Buttons
            Spin.Visibility = Visibility.Collapsed;
            nudgeDown0.Visibility = Visibility.Collapsed;
            nudgeDown1.Visibility = Visibility.Collapsed;
            nudgeDown2.Visibility = Visibility.Collapsed;
            nudgeDown3.Visibility = Visibility.Collapsed;
            nudgeDown4.Visibility = Visibility.Collapsed;
            nudgeUp0.Visibility = Visibility.Collapsed;
            nudgeUp1.Visibility = Visibility.Collapsed;
            nudgeUp2.Visibility = Visibility.Collapsed;
            nudgeUp3.Visibility = Visibility.Collapsed;
            nudgeUp4.Visibility = Visibility.Collapsed;
            Hold.Visibility = Visibility.Collapsed;
            #endregion
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (playerDollars >= playerBet)
            {
                Slots.Spin(random);
                Slots.AssignImages(slotReelImages);
                Spin.Visibility = Visibility.Collapsed;
                NudgeAndHoldEnable();
                playerDollars -= 5;
                textBlockDollars.Text = $"${playerDollars}.";
            }
            else
            {
                Spin.Visibility = Visibility.Collapsed;
                textBlockDollars.Text = $"${playerDollars}. Please Add Cash.";
            }
        }

        private void Hold_Click(object sender, RoutedEventArgs e)
        {
            NudgeAndHoldDisable();
            playerDollars += Slots.CalculateWin();
            Spin.Visibility = Visibility.Visible;
            textBlockDollars.Text = $"${playerDollars}.";
        }

        private void AddCash_Click(object sender, RoutedEventArgs e)
        {
            playerDollars += 10;
            Spin.Visibility = Visibility.Visible;
            textBlockDollars.Text = $"${playerDollars}.";
        }
        #region Nudge Up Buttons
        private void NudgeUp0_Click(object sender, RoutedEventArgs e)
        {
            playerDollars -= 2;
            Slots.NudgeRowUp(0, slotReelImages);
            NudgeAndHoldDisable();
            Spin.Visibility = Visibility.Visible;
            playerDollars += Slots.CalculateWin();
            textBlockDollars.Text = $"${playerDollars}.";
        }

        private void NudgeUp1_Click(object sender, RoutedEventArgs e)
        {
            playerDollars -= 2;
            Slots.NudgeRowUp(1, slotReelImages);
            NudgeAndHoldDisable();
            Spin.Visibility = Visibility.Visible;
            playerDollars += Slots.CalculateWin();
            textBlockDollars.Text = $"${playerDollars}.";
        }

        private void NudgeUp2_Click(object sender, RoutedEventArgs e)
        {
            playerDollars -= 2;
            Slots.NudgeRowUp(2, slotReelImages);
            NudgeAndHoldDisable();
            Spin.Visibility = Visibility.Visible;
            playerDollars += Slots.CalculateWin();
            textBlockDollars.Text = $"${playerDollars}.";
        }

        private void NudgeUp3_Click(object sender, RoutedEventArgs e)
        {
            playerDollars -= 2;
            Slots.NudgeRowUp(3, slotReelImages);
            NudgeAndHoldDisable();
            Spin.Visibility = Visibility.Visible;
            playerDollars += Slots.CalculateWin();
            textBlockDollars.Text = $"${playerDollars}.";
        }

        private void NudgeUp4_Click(object sender, RoutedEventArgs e)
        {
            playerDollars -= 2;
            Slots.NudgeRowUp(4, slotReelImages);
            NudgeAndHoldDisable();
            Spin.Visibility = Visibility.Visible;
            playerDollars += Slots.CalculateWin();
            textBlockDollars.Text = $"${playerDollars}.";
        }
        #endregion
        private void NudgeAndHoldDisable()
        {
            nudgeDown0.Visibility = Visibility.Collapsed;
            nudgeDown1.Visibility = Visibility.Collapsed;
            nudgeDown2.Visibility = Visibility.Collapsed;
            nudgeDown3.Visibility = Visibility.Collapsed;
            nudgeDown4.Visibility = Visibility.Collapsed;
            nudgeUp0.Visibility = Visibility.Collapsed;
            nudgeUp1.Visibility = Visibility.Collapsed;
            nudgeUp2.Visibility = Visibility.Collapsed;
            nudgeUp3.Visibility = Visibility.Collapsed;
            nudgeUp4.Visibility = Visibility.Collapsed;
            Hold.Visibility = Visibility.Collapsed;
        }
        private void NudgeAndHoldEnable()
        {
            nudgeUp0.Visibility = Visibility.Visible;
            nudgeUp1.Visibility = Visibility.Visible;
            nudgeUp2.Visibility = Visibility.Visible;
            nudgeUp3.Visibility = Visibility.Visible;
            nudgeUp4.Visibility = Visibility.Visible;
            nudgeDown0.Visibility = Visibility.Visible;
            nudgeDown1.Visibility = Visibility.Visible;
            nudgeDown2.Visibility = Visibility.Visible;
            nudgeDown3.Visibility = Visibility.Visible;
            nudgeDown4.Visibility = Visibility.Visible;
            Hold.Visibility = Visibility.Visible;
        }
        #region Nudge Down Buttons
        private void NudgeDown0_Click(object sender, RoutedEventArgs e)
        {
            playerDollars -= 2;
            Slots.NudgeRowDown(0, slotReelImages);
            NudgeAndHoldDisable();
            Spin.Visibility = Visibility.Visible;
            playerDollars += Slots.CalculateWin();
            textBlockDollars.Text = $"${playerDollars}.";
        }

        private void NudgeDown1_Click(object sender, RoutedEventArgs e)
        {
            playerDollars -= 2;
            Slots.NudgeRowDown(1, slotReelImages);
            NudgeAndHoldDisable();
            Spin.Visibility = Visibility.Visible;
            playerDollars += Slots.CalculateWin();
            textBlockDollars.Text = $"${playerDollars}.";
        }

        private void NudgeDown2_Click(object sender, RoutedEventArgs e)
        {
            playerDollars -= 2;
            Slots.NudgeRowDown(2, slotReelImages);
            NudgeAndHoldDisable();
            Spin.Visibility = Visibility.Visible;
            playerDollars += Slots.CalculateWin();
            textBlockDollars.Text = $"${playerDollars}.";
        }

        private void NudgeDown3_Click(object sender, RoutedEventArgs e)
        {
            playerDollars -= 2;
            Slots.NudgeRowDown(3, slotReelImages);
            NudgeAndHoldDisable();
            Spin.Visibility = Visibility.Visible;
            playerDollars += Slots.CalculateWin();
            textBlockDollars.Text = $"${playerDollars}.";
        }

        private void NudgeDown4_Click(object sender, RoutedEventArgs e)
        {
            playerDollars -= 2;
            Slots.NudgeRowDown(4, slotReelImages);
            NudgeAndHoldDisable();
            Spin.Visibility = Visibility.Visible;
            playerDollars += Slots.CalculateWin();
            textBlockDollars.Text = $"${playerDollars}.";
        }
        #endregion
    }
}

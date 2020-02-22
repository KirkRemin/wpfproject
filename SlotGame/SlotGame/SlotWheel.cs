using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace SlotGame
{
    class SlotWheel
    {
        #region Properties
        private int[,] current { get; set; }
        #endregion
        public SlotWheel(Random rand)
        {
            current = new int[5, 5];
        }
        public void Spin(Random rand)
        {
            //Assign Images based on random number
            for (int i = 0; i < 5; i++)
            {
                for (int k = 0; k < 5; k++)
                {
                    current[i, k] = rand.Next(0, 13);
                }
            }
        }
       
        public int CalculateWin()
        {
            int winnings = 0;
            #region Line 1, 2 & 3 - Top, Middle Bottom - Straight
            for (int row = 0; row < 3; row++)
            {
                for (int i = 0; i < 13; i++)
                {
                    int a = 0;
                    if (current[row, 0] == i)
                    {
                        a += 1;
                    }
                    if (current[row, 1] == i)
                    {
                        a += 1;
                    }
                    if (current[row, 2] == i)
                    {
                        a += 1;
                    }
                    if (current[row, 3] == i)
                    {
                        a += 1;
                    }
                    if (current[row, 4] == i)
                    {
                        a += 1;
                    }
                    if (a == 3)
                    {
                        winnings += i;
                    }
                    else if (a == 4)
                    {
                        winnings += i * 2;
                    }
                    else if (a == 5)
                    {
                        winnings += i * 4;
                    }
                }
            }
            #endregion
            #region Line 4 -  T, T, M , B, B
            for (int i = 0; i < 13; i++)
            {
                int a = 0;
                if (current[0, 0] == i)
                {
                    a += 1;
                }
                if (current[0, 1] == i)
                {
                    a += 1;
                }
                if (current[1, 2] == i)
                {
                    a += 1;
                }
                if (current[2, 3] == i)
                {
                    a += 1;
                }
                if (current[2, 4] == i)
                {
                    a += 1;
                }
                if (a == 3)
                {
                    winnings += i + 4;
                }
                else if (a == 4)
                {
                    winnings += i * 3;
                }
                else if (a == 5)
                {
                    winnings += i * 5;
                }
            }
            #endregion
            #region Line 5 - B, B, M, T, T
            for (int i = 0; i < 13; i++)
            {
                int a = 0;
                if (current[2, 0] == i)
                {
                    a += 1;
                }
                if (current[2, 1] == i)
                {
                    a += 1;
                }
                if (current[1, 2] == i)
                {
                    a += 1;
                }
                if (current[0, 3] == i)
                {
                    a += 1;
                }
                if (current[0, 4] == i)
                {
                    a += 1;
                }
                if (a == 3)
                {
                    winnings += i + 4;
                }
                else if (a == 4)
                {
                    winnings += i * 3;
                }
                else if (a == 5)
                {
                    winnings += i * 5;
                }
            }
            #endregion
            #region Line 6 - T,M,T,M,T
            for (int i = 0; i < 13; i++)
            {
                int a = 0;
                if (current[0, 0] == i)
                {
                    a += 1;
                }
                if (current[1, 1] == i)
                {
                    a += 1;
                }
                if (current[0, 2] == i)
                {
                    a += 1;
                }
                if (current[1, 3] == i)
                {
                    a += 1;
                }
                if (current[0, 4] == i)
                {
                    a += 1;
                }
                if (a == 3)
                {
                    winnings += i + 6;
                }
                else if (a == 4)
                {
                    winnings += i * 4;
                }
                else if (a == 5)
                {
                    winnings += i * 6;
                }
            }
            #endregion
            #region Line 7 - B,M,B,M,B
            for (int i = 0; i < 13; i++)
            {
                int a = 0;
                if (current[2, 0] == i)
                {
                    a += 1;
                }
                if (current[1, 1] == i)
                {
                    a += 1;
                }
                if (current[2, 2] == i)
                {
                    a += 1;
                }
                if (current[1, 3] == i)
                {
                    a += 1;
                }
                if (current[2, 4] == i)
                {
                    a += 1;
                }
                if (a == 3)
                {
                    winnings += i + 6;
                }
                else if (a == 4)
                {
                    winnings += i * 4;
                }
                else if (a == 5)
                {
                    winnings += i * 6;
                }
            }
            #endregion
            #region Line 8 - M,T,M,T,M
            for (int i = 0; i < 13; i++)
            {
                int a = 0;
                if (current[1, 0] == i)
                {
                    a += 1;
                }
                if (current[0, 1] == i)
                {
                    a += 1;
                }
                if (current[1, 2] == i)
                {
                    a += 1;
                }
                if (current[0, 3] == i)
                {
                    a += 1;
                }
                if (current[1, 4] == i)
                {
                    a += 1;
                }
                if (a == 3)
                {
                    winnings += i + 6;
                }
                else if (a == 4)
                {
                    winnings += i * 4;
                }
                else if (a == 5)
                {
                    winnings += i * 6;
                }
            }
            #endregion
            #region Line 9 - M,B,M,B,M
            for (int i = 0; i < 13; i++)
            {
                int a = 0;
                if (current[1, 0] == i)
                {
                    a += 1;
                }
                if (current[2, 1] == i)
                {
                    a += 1;
                }
                if (current[1, 2] == i)
                {
                    a += 1;
                }
                if (current[2, 3] == i)
                {
                    a += 1;
                }
                if (current[1, 4] == i)
                {
                    a += 1;
                }
                if (a == 3)
                {
                    winnings += i + 6;
                }
                else if (a == 4)
                {
                    winnings += i * 4;
                }
                else if (a == 5)
                {
                    winnings += i * 6;
                }
            }
            #endregion
            #region Line 10 - B,M,T,M,B
            for (int i = 0; i < 13; i++)
            {
                int a = 0;
                if (current[2, 0] == i)
                {
                    a += 1;
                }
                if (current[1, 1] == i)
                {
                    a += 1;
                }
                if (current[0, 2] == i)
                {
                    a += 1;
                }
                if (current[1, 3] == i)
                {
                    a += 1;
                }
                if (current[2, 4] == i)
                {
                    a += 1;
                }
                if (a == 3)
                {
                    winnings += i + 6;
                }
                else if (a == 4)
                {
                    winnings += i * 4;
                }
                else if (a == 5)
                {
                    winnings += i * 6;
                }
            }
            #endregion
            #region Line 11 - T,M,B,M,T
            for (int i = 0; i < 13; i++)
            {
                int a = 0;
                if (current[0, 0] == i)
                {
                    a += 1;
                }
                if (current[1, 1] == i)
                {
                    a += 1;
                }
                if (current[2, 2] == i)
                {
                    a += 1;
                }
                if (current[1, 3] == i)
                {
                    a += 1;
                }
                if (current[0, 4] == i)
                {
                    a += 1;
                }
                if (a == 3)
                {
                    winnings += i + 6;
                }
                else if (a == 4)
                {
                    winnings += i * 4;
                }
                else if (a == 5)
                {
                    winnings += i * 6;
                }
            }
            #endregion
            #region Line 12 - M,T,M,B,M
            for (int i = 0; i < 13; i++)
            {
                int a = 0;
                if (current[1, 0] == i)
                {
                    a += 1;
                }
                if (current[0, 1] == i)
                {
                    a += 1;
                }
                if (current[1, 2] == i)
                {
                    a += 1;
                }
                if (current[2, 3] == i)
                {
                    a += 1;
                }
                if (current[1, 4] == i)
                {
                    a += 1;
                }
                if (a == 3)
                {
                    winnings += i + 6;
                }
                else if (a == 4)
                {
                    winnings += i * 4;
                }
                else if (a == 5)
                {
                    winnings += i * 6;
                }
            }
            #endregion
            #region Line 13 - M,B,M,T,M
            for (int i = 0; i < 13; i++)
            {
                int a = 0;
                if (current[1, 0] == i)
                {
                    a += 1;
                }
                if (current[2, 1] == i)
                {
                    a += 1;
                }
                if (current[1, 2] == i)
                {
                    a += 1;
                }
                if (current[0, 3] == i)
                {
                    a += 1;
                }
                if (current[1, 4] == i)
                {
                    a += 1;
                }
                if (a == 3)
                {
                    winnings += i + 6;
                }
                else if (a == 4)
                {
                    winnings += i * 4;
                }
                else if (a == 5)
                {
                    winnings += i * 6;
                }
            }
            #endregion
            return winnings;
        }
        public void NudgeRowUp(int column, Image[,] imageArray)
        {
            current[4, column] = current[1, column];
            current[0, column] = current[4, column];
            current[4, column] = current[2, column];
            current[1, column] = current[4, column];
            current[2, column] = current[3, column];
            AssignImages(imageArray);
        }
        public void NudgeRowDown(int column, Image[,] imageArray)
        {
            current[4, column] = current[1, column];
            current[2, column] = current[4, column];
            current[4, column] = current[0, column];
            current[1, column] = current[4, column];
            current[0, column] = current[3, column];
            AssignImages(imageArray);
        }
        public void AssignImages(Image[,] imageBox)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int k = 0; k < 5; k++)
                {
                    if (i < 3)
                    {
                        if (current[i, k] == 0) { imageBox[i, k].Source = new BitmapImage(new Uri("Images/0.PNG", UriKind.RelativeOrAbsolute)); }
                        else if (current[i, k] == 1) { imageBox[i, k].Source = new BitmapImage(new Uri("Images/1.PNG", UriKind.RelativeOrAbsolute)); }
                        else if (current[i, k] == 2) { imageBox[i, k].Source = new BitmapImage(new Uri("Images/2.PNG", UriKind.RelativeOrAbsolute)); }
                        else if (current[i, k] == 3) { imageBox[i, k].Source = new BitmapImage(new Uri("Images/3.PNG", UriKind.RelativeOrAbsolute)); }
                        else if (current[i, k] == 4) { imageBox[i, k].Source = new BitmapImage(new Uri("Images/4.PNG", UriKind.RelativeOrAbsolute)); }
                        else if (current[i, k] == 5) { imageBox[i, k].Source = new BitmapImage(new Uri("Images/5.PNG", UriKind.RelativeOrAbsolute)); }
                        else if (current[i, k] == 6) { imageBox[i, k].Source = new BitmapImage(new Uri("Images/6.PNG", UriKind.RelativeOrAbsolute)); }
                        else if (current[i, k] == 7) { imageBox[i, k].Source = new BitmapImage(new Uri("Images/7.PNG", UriKind.RelativeOrAbsolute)); }
                        else if (current[i, k] == 8) { imageBox[i, k].Source = new BitmapImage(new Uri("Images/8.PNG", UriKind.RelativeOrAbsolute)); }
                        else if (current[i, k] == 9) { imageBox[i, k].Source = new BitmapImage(new Uri("Images/9.PNG", UriKind.RelativeOrAbsolute)); }
                        else if (current[i, k] == 10) { imageBox[i, k].Source = new BitmapImage(new Uri("Images/10.PNG", UriKind.RelativeOrAbsolute)); }
                        else if (current[i, k] == 11) { imageBox[i, k].Source = new BitmapImage(new Uri("Images/11.PNG", UriKind.RelativeOrAbsolute)); }
                        else imageBox[i, k].Source = new BitmapImage(new Uri("Images/12.PNG", UriKind.RelativeOrAbsolute));
                    }
                }
            }
        }

    }
}

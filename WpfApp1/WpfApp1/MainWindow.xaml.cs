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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region First Change
        #endregion
        #region Second Change
        #endregion
        #region Third Change
        #endregion
        public MainWindow()
        {
            InitializeComponent();
        }


        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UserList win2 = new UserList();
            win2.Show();
            this.Close();
        }
        /*
         Block Comments
             */
        /// <summary>
        /// test method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win1 = new MainWindow();
            win1.Show();
            this.Close();
        }
    }
}

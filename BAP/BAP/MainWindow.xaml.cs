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

namespace BAP
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
        public MainWindow(string name, string passward)
        {
            InitializeComponent();
            UserNameTextBox.Text = name;
            PasswordTextBox.Text = passward;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string userName = UserNameTextBox.Text;
            string userPass = PasswordTextBox.Text;
            if (userName != "" && userPass != "")
            {
                //if exist
                VideosWindow vw = new VideosWindow(userName);
                vw.Show();
                this.Close();

                // else
                //MessageBox.Show("שם משתמש או הסיסמה שגויים, אנא נסה שנית");
            }
            else
                MessageBox.Show("");
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            SignUpWindow sw = new SignUpWindow();
            sw.Show();
            this.Close();
        }

        private void RemembermeB_Checked(object sender, RoutedEventArgs e)
        {
            if (RemembermeB.IsChecked == true)
            {
                //one optitinal offer for implements
                //cause that in the next time you enter the app your user is login automaticly.
                //also change all the other "rememberMe" fields (other users) to false 
            }
            else
            {
                //update the "rememberMe" field for this user to false
            }
        }
    }
}

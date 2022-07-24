using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MaterialDesignThemes.Wpf;

namespace Coco_Master.Views
{

    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
        }
        private string userName = "Admin";
        private string password = "1234";       

        public string UserName 
        { 
            get => userName; 
            set => userName = value;
        }
        public string Password 
        { 
            get => password; 
            set => password = value; 
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
          
            Application.Current.Shutdown();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            //if(txtUserName.Text == UserName)
            //{
            //    if(txtPassword.Password == Password)
            //    {
            //        this.Hide();
            //    }
            //    else if(txtPassword == null)
            //    {
            //        string emptyPassword = "Password is Empty";
            //        txtBlockPassword.Text = emptyPassword;                    
            //    }
            //    else
            //    {
            //        string wrongPassword = "Password is Wrong !!";
            //        txtBlockPassword.Text = wrongPassword;
            //    }
            //}
            //else if(txtUserName.Text == null)
            //{
            //    string emptyUserName = "Username is empty";
            //    txtBlockUserName.Text = emptyUserName;
            //}
            //else
            //{
            //    string wrongUserName = "Username is Wrong !!";
            //    txtBlockUserName.Text = wrongUserName;
            //}         

            if (txtUserName.Text == UserName || txtPassword.Password == Password)
            {
                this.Hide();
                new ShellView().Show(); 
                            
            }
            else
            {
                string message = "Username or Password is wrong";
                txtBlockPassword.Text = message;
            }
        }
    }
}

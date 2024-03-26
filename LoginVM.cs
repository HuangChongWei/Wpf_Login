using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Wpf_Login
{
    public class LoginVM : NotifyPropertyBase
    {
        private LoginModel loginM;

        public LoginVM()
        {
            loginM = new LoginModel(); // 實例化 _loginM
        }

        public string UserName
        {
            get { return loginM.UserName; }
            set
            {
                loginM.UserName = value;
                OnPropertyChanged("UserName");
            }
        }


        public string Password
        {
            get { return loginM.Password; }
            set
            {
                loginM.Password = value;
                OnPropertyChanged("PassWord");
            }
        }

        void LoginFunc()
        {
            if (UserName == "willy" && Password == "666")
            {
                index index = new index();
                index.Show();

                //this.Hide();
            }
            else
            {
                MessageBox.Show("帳號:willy,密碼:666");
                UserName = "";
                Password = "";
            }
        }

        bool CanLoginExecute()
        {
            return true;
        }

        public ICommand LoginAction
        {
            get
            {
                return new RelayCommand(LoginFunc, CanLoginExecute);
            }
        }


    }
}

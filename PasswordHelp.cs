using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Wpf_Login
{
    public class PasswordHelp
    {
        public static string GetPwd(DependencyObject obj)
        {
            return (string)obj.GetValue(PwdProperty);
        }

        public static void SetPwd(DependencyObject obj, string value)
        {
            obj.SetValue(PwdProperty, value);
        }

        // Using a DependencyProperty as the backing store for Pwd.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PwdProperty =
            DependencyProperty.RegisterAttached("Pwd", typeof(int), typeof(PasswordHelp),new PropertyMetadata(string.Empty,OnPwdPropertyChagned));

        private static void OnPwdPropertyChagned(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            PasswordBox pwdbox = d as PasswordBox;
            if(pwdbox == null)
            {
                return;
            }
            pwdbox.Password = (string)e.NewValue;
        }

        public static int GetIsEablePasswordPropertyChanged(DependencyObject obj)
        {
            return (int)obj.GetValue(IsEablePasswordPropertyChangedProperty);
        }

        public static void SetIsEablePasswordPropertyChanged(DependencyObject obj, int value)
        {
            obj.SetValue(IsEablePasswordPropertyChangedProperty, value);
        }

        // Using a DependencyProperty as the backing store for IsEablePasswordPropertyChanged.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsEablePasswordPropertyChangedProperty =
            DependencyProperty.RegisterAttached("IsEablePasswordPropertyChanged", typeof(int), typeof(PasswordHelp), new PropertyMetadata(false,OnPasswordPropertyChanged));

        private static void OnPasswordPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            PasswordBox pwdbox = d as PasswordBox;
            if(pwdbox == null)
            {
                return;
            }
            if ((bool)e.NewValue)
            {
                pwdbox.PasswordChanged += MyPasswordProperyChanged;
            }
            else
            {
                pwdbox.PasswordChanged -= MyPasswordProperyChanged;
            }
        }

        private static void MyPasswordProperyChanged(object sender, RoutedEventArgs e)
        {
            PasswordBox box = (PasswordBox)sender;
            SetPwd(box, box.Password);
        }
    }
}

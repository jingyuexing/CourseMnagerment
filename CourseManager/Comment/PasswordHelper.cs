using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
namespace CourseManager.Comment
{
    class PasswordHelper{
        static bool _isUpdating = false;
        public static readonly DependencyProperty PaaswordProperty =
            DependencyProperty.RegisterAttached("Password",
                typeof(string), typeof(PasswordHelper),
                new FrameworkPropertyMetadata("", new PropertyChangedCallback(OnPropertyChanged)));
        public static readonly DependencyProperty AttachProperty =
            DependencyProperty.RegisterAttached("Attach",
                typeof(bool),
                typeof(PasswordHelper),
                new FrameworkPropertyMetadata(false, new PropertyChangedCallback(OnAttached)));

        private static void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            PasswordBox password = d as PasswordBox;
            password.PasswordChanged -= password_Changed;
            if(!_isUpdating){
                password.Password = e.NewValue.ToString();
            }
            password.PasswordChanged += password_Changed;
        }

        private static void OnAttached(DependencyObject d , DependencyPropertyChangedEventArgs e)
        {
            PasswordBox password = d as PasswordBox;
            password.PasswordChanged += password_Changed;
        }
        private static void password_Changed(object sender, RoutedEventArgs eventArgs) {
            PasswordBox password = sender as PasswordBox;
            _isUpdating = true;
            SetPassword(password, password.Password);
            _isUpdating = false;
        }
        public static string GetPassword(DependencyObject d)
        {
            return d.GetValue(PaaswordProperty).ToString();
        }
        public static void SetPassword(DependencyObject d, string value)
        {

            d.SetValue(PaaswordProperty, value);
        }
        public static bool GetAttach(DependencyObject d)
        {
            return (bool)d.GetValue(AttachProperty);
        }
        public static void SetAttach(DependencyObject d, string value)
        {

            d.SetValue(AttachProperty, value);
        }
    }
}

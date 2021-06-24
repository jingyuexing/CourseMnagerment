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
using System.Windows.Shapes;

namespace CourseManager.View
{
    /// <summary>
    /// Login.xaml 的交互逻辑
    /// </summary>
    public partial class Login : Window
    {
        private String UserName;
        private String Password;
        public Login()
        {
            InitializeComponent();
        }
        private String GetUserName() {
            return this.UserName;
        }
        private String GetPassword() {
            return this.Password;
        }
        private void CloseLogin(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Log_in(object sender, RoutedEventArgs e)
        {
            System.Console.WriteLine("登录检查!");
        }
        private string getUserName() {
            /*System.Console.WriteLine(this.Resources.);*/
            return 
        }
        // 移动登录窗口

    }
}

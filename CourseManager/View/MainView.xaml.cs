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
using CourseManager.Comment;
namespace CourseManager.View
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
            Object FE = this.FindName("");
        }
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
        public CommentBase NavChangeCommand { get; set; }
        private FrameworkElement _mainContent;
        public FrameworkElement MainContent
        {
            get { return _mainContent; }
            set {
                _mainContent = value;
                this.DoNotify();
             }
        }
    }
}

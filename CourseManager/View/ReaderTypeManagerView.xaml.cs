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
using CourseManager.ViewModel;
using CourseManager.Model;
namespace CourseManager.View
{
    /// <summary>
    /// ReaderTypeManagerView.xaml 的交互逻辑
    /// </summary>
    public partial class ReaderTypeManagerView : UserControl
    {
        private ReaderTypeManagerViewModel model;
        public ReaderTypeManagerView()
        {
            this.model = new ReaderTypeManagerViewModel();
            this.DataContext = this.model; 
            InitializeComponent();
        }
    }
}

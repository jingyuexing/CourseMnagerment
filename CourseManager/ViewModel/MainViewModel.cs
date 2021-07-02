using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CourseManager.Model;
using CourseManager.Comment;
using System.Reflection;

namespace CourseManager.ViewModel
{
    class MainViewModel:LoginModelNotify{
        public ReaderModel ReadInfor { get; set; }
        public CommentBase NavChangedCommand{get;set;}
        private FrameworkElement _mainContent;
        public FrameworkElement MainContent {
            get { return _mainContent;}
            set { _mainContent = value; this.DoNotify(); }
        }
        public MainViewModel(){
            ReaderModel ReadInfor = new ReaderModel();
            this.NavChangedCommand = new CommentBase();
            this.NavChangedCommand.DoExcute = new Action<object>(DoNavChanged);
            this.NavChangedCommand.DoCanExecute = new Func<object, bool>((o) => true);
        }
        private void DoNavChanged(object obj){
            Type type = Type.GetType("CourseManager.View."+obj.ToString());
            ConstructorInfo cti = type.GetConstructor(System.Type.EmptyTypes);
            this.MainContent = (FrameworkElement)cti.Invoke(null);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
namespace CourseManager.Comment
{
    public class CommentBase : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter){
            return DoCanExecute?.Invoke(parameter) == true;
        }

        public void Execute(object parameter){
            DoExcute?.Invoke(parameter);
        }
        public Action<object> DoExcute { get; set; }
        public Func<object,bool> DoCanExecute { get;set;}
    }
}

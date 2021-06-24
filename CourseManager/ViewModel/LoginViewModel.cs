using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;
using CourseManager.Comment;
using CourseManager.Model;
namespace CourseManager.ViewModel
{
    class LoginViewModel
    {
        public LoginModel Login { get; set; }
        public  CommentBase CloseWindowCommand { get; set; }
        public LoginViewModel(){
            this.Login = new LoginModel();
            this.Login.Username = "Alen";
            this.CloseWindowCommand = new CommentBase();
            this.CloseWindowCommand.DoExcute = new Action<object>((o) =>{
                (o as Window).Close();
            });
            this.CloseWindowCommand.DoCanExecute = new Func<object, bool>((o) =>
            {
                return true;
            });
        }
    }
}

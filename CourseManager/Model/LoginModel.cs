using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManager.Comment;
namespace CourseManager.Model
{
    class LoginModel: LoginModelNotify
    {
        private string _usename;
        public string Username
        {
            get { return _usename; }
            set
            {
                _usename = value;
                this.DoNotify();
            }
        }
        private string _password;
        public string Password
        {
            get {return this._password; }
            set
            {
                _password = value;
                this.DoNotify();
            }
        }
    }
}

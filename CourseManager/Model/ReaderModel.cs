using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManager.Comment;
namespace CourseManager.Model
{
    class ReaderModel : LoginModelNotify{
        /**
         * 读者编号/借书证号
         */
        private int _id;
        /**
         * 读者姓名
         */
        private string _name;
        /**
         * 读者类别
         */
        private int _sex;
        /**
         * 单位代码/单位名称
         */
        private string _dept;
        /**
         * 电话号码
         */
        private string _phone;
        /**
         * 电子邮箱
         */
        private string _email;
        /**
         * 读者登记日期
         */
        private float _dateReg;
        /**
         * 读者照片
         */
        private string _photo;
        private char[] _status;
        private int _borrowQty;
        private string _pwd;
        private int _adminroles;
        ReaderModel()
        {

        }
        public int Id
        {
            get{return _id;}
            set { _id = value;this.DoNotify(); }
        }
        public string Name {
            get{return _name;}
            set{_name = value;this.DoNotify();}
        }
        public int Sex{
            get{return _sex;}
            set{_sex = value;this.DoNotify();}
        }
        public string Dept{
            get{return _dept;}
            set{_dept = value;this.DoNotify();}
        }
        public string Phone{
            get{return _phone;}
            set{_phone = value;this.DoNotify();}
        }
        public string Email{
            get{return _email;}
            set{_email = value;this.DoNotify();}
        }
    }
}

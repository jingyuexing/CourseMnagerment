using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManager.Model
{
    class ReaderModel : IDAL{
        /**
         * 读者编号/借书证号
         */
        private int id;
        /**
         * 读者姓名
         */
        private string name;
        /**
         * 读者类别
         */
        private int sex;
        /**
         * 单位代码/单位名称
         */
        private string dept;
        /**
         * 电话号码
         */
        private string phone;
        /**
         * 电子邮箱
         */
        private string email;
        /**
         * 读者登记日期
         */
        private float dateReg;
        /**
         * 读者照片
         */
        private string photo;
        private char[] status;
        private int borrowQty;
        private string pwd;
        private int adminroles;
        ReaderModel(){

        }
        public void create()
        {
            throw new NotImplementedException();
        }

        public void delete()
        {
            throw new NotImplementedException();
        }

        public void update()
        {
            throw new NotImplementedException();
        }

        public void write()
        {
            throw new NotImplementedException();
        }
    }
}

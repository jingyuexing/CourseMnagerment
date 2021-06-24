using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManager.Model
{
    class BorrowModel : IDAL
    {
        /**
         * 借书序号 主键
         */
        int borrowID;
        /**
         * 读者序号 外键
         */
        int readerID;
        /**
         * 图书序号 外键
         */
        int bookID;
        /**
         * 续借次数
         */
        int continuetimes;
        /**
         * 借书日期
         */
        string dateOut;
        /**
         * 应还日期
         */
        string dateRetPlan;
        /**
         * 实际还书日期
         */
        string dateRetAct;
        /**
         * 超期天数
         */
        int overDay;
        /**
         * 超期罚金
         */
        float overMoney;
        /**
         * 罚款金额
         */
        float punishMoney;
        /**
         * 是否已经还书
         */
        byte isReturn;
        /**
         * 借书操作员
         */
        string operatorLend;
        /**
         * 还书操作员
         */
        string operatorRet;
        BorrowModel()
        {

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

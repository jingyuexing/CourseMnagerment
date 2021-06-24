using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManager.Model
{
    class ReaderTypeModel:IDAL
    {
        /**
         * 读者类别
         */
        private int rdType;
        /**
         * 读者类别名称
         */
        private char[] TypeName;
        /**
         * 可借书数量
         */
        private int canLendQty;
        /**
         * @type int
         */
        private int canLendDay;
        /**
         * @type int
         */
        private int canContinueTimes;
        /**
         * 罚款率 (元/天)
         */
        private float punishRate;
        /**
         * 证书有效年限 非空 0表示永久有效
         */
        private int dateValid;

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CourseManager.Model
{
    public enum Lang{
        zh_CN = 0, //中国中文
        en_UK = 1, // 英语英国
        jp_JP = 2, //日文 日本
        ru_RU = 3, // 俄语 俄罗斯
        DE_DE = 4, // 德文 德国
        fr_FR = 5 //法语 法国
    }
    public class BookModel:IDAL{
        public int id { get; set;}
        public string code { get; set; }
        public string name { get; set; }
        public string author { get; set; }
        public string press { get; set; }
        public int pages { get; set; }
        public float price { get; set; }
        public string cover { get; set; }
        public Lang language { get; set; }
        public string brief { get; set; }
        public string imageURL { get; set; }
        public string status { get; set; }
        BookModel(){
        }
        public void create()
        {
            this.brief = "";
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

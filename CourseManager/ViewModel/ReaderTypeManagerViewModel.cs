using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManager.Comment;
using CourseManager.Model;
namespace CourseManager.ViewModel
{
    public class ReaderTypeManagerViewModel{
        ReaderModel reader;
        public ReaderTypeManagerViewModel()
        {
            this.reader = new ReaderModel();
        }
    }
}

using EntityLayer_.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer_.Abstract
{
    public interface IWriterService
    {
        List<Writer>GetList();
        void WriteAdd(Writer writer);
        void WriteDelete(Writer writer);
        void WriteUpdate(Writer writer);
        Writer GetByID(int id);
    }
}

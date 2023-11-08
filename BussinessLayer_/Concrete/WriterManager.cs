using BussinessLayer_.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer_.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer_.Concrete
{
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public Writer GetByID(int id)
        {
            return _writerDal.Get(x => x.WriterID == id);
        }

        public List<Writer> GetList()
        {
            return _writerDal.List();
        }

        public void WriteAdd(Writer writer)
        {
            _writerDal.Insert(writer);
        }

        public void WriteDelete(Writer writer)
        {
            _writerDal.Delete(writer);
        }

        public void WriteUpdate(Writer writer)
        {
            _writerDal.Update(writer);
        }
    }
}

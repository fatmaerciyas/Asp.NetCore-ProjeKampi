using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        IWriterDal writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            this.writerDal = writerDal;
        }

        public Writer GetByID(int id)
        {
            return writerDal.GetByID(id);
        }

        public List<Writer> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Writer t)
        {
            writerDal.Insert(t);
        }

        public void TDelete(Writer t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Writer t)
        {
            t.WriterStatus = true;
            writerDal.Update(t);
        }

        public Writer WriterControl(string Mail, string password)
        {
            return writerDal.Get(x => x.WriterMail == Mail && x.WriterPassword == password);
        }
    }
}

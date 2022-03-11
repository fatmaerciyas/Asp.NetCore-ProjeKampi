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
    public class MessageManager : IMessageService
    {
        IMessageDal messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            this.messageDal = messageDal;
        }

        public Message GetByID(int id)
        {
            return messageDal.GetByID(id);

        }

        public List<Message> GetInboxByWriter(string receiver)
        {
            return messageDal.GetListAll(x => x.Receiver == receiver); // Alicisi biz olan maili getir
        }

        public List<Message> GetList()
        {
            return messageDal.GetListAll();
        }

        public void TAdd(Message t)
        {
            messageDal.Insert(t);
        }

        public void TDelete(Message t)
        {
            messageDal.Delete(t);
        }

        public void TUpdate(Message t)
        {
            messageDal.Update(t);
        }
    }
}

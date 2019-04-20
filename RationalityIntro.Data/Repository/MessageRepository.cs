using RationalityIntro.Data.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalityIntro.Data.Repository
{
    public class MessageRepository
    {
        public void AddMessage(Message message)
        {
            using (var context = new RationalityIntroDBEntities())
            {
                context.Messages.Add(message);
            }
        }

        public void DeleteMessage(int Id)
        {
            using (var context = new RationalityIntroDBEntities())
            {
                Message message = context.Messages.Find(Id);
                context.Messages.Remove(message);
            }
        }

        public Message GetMessageById(int Id)
        {
            using (var context = new RationalityIntroDBEntities())
            {
                return context.Messages.Find(Id);
            }
        }
    }
}

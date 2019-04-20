using RationalityIntro.Data.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalityIntro.Data.Repository
{
    public class ActRepository
    {
        public void AddAct(Act act)
        {
            using (var context = new RationalityIntroDBEntities())
            {
                context.Acts.Add(act);
            }
        }

        public void DeleteAct(int Id)
        {
            using (var context = new RationalityIntroDBEntities())
            {
                Act act = context.Acts.Find(Id);
                context.Acts.Remove(act);
            }
        }

        public Act GetActById(int Id)
        {
            using (var context = new RationalityIntroDBEntities())
            {
                return context.Acts.Find(Id);
            }
        }
    }
}

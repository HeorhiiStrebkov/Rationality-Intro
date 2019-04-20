using RationalityIntro.Data.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalityIntro.Data
{
    public class HumanRepository
    {
        public List<Human> GetListOfHumans()
        {
            using (var context = new RationalityIntroDBEntities())
            {
                return context.Humen.ToList();
            }
        }

        public void AddHuman(Human human)
        {
            using (var context = new RationalityIntroDBEntities())
            {
                context.Humen.Add(human);
            }
        }

        public void DeleteHuman(int Id)
        {
            using (var context = new RationalityIntroDBEntities())
            {
                Human human = context.Humen.Find(Id);
                context.Humen.Remove(human);
            }
        }
         
        public Human GetHumanById(int Id)
        {
            using (var context = new RationalityIntroDBEntities())
            {
                return context.Humen.Find(Id);
            }
        }
    }
}
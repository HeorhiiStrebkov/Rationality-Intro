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
        private List<Human> humanList = new List<Human>();
        private List<Human> humansEF;
        public List<Human> GetListOfHumans()
        {
            using (var context = new RationalityIntroDBEntities())
            {
                humansEF = context.Humen.ToList();
                ListInitialization();
                return humanList;
            }
        }


        private void ListInitialization()
        {
            foreach (var item in humansEF)
            {
               humanList.Add(item);
            }

        }

        public int AddHuman(Human human) 
        {
            using (var context = new RationalityIntroDBEntities())
            {
                var exists = context.Humen.Any(c => c.Id == human.Id);

                if (exists)
                    throw new ArgumentException("Not uniue"); 

                context.Humen.Add(human);
                context.SaveChanges();
                return human.Id;
            }
        }

        public void DeleteHuman(int? Id)
        {
            using (var context = new RationalityIntroDBEntities())
            {
                Human human = context.Humen.Find(Id);
                context.Humen.Remove(human);
                context.SaveChanges();
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
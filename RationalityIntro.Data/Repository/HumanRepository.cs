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

        public void AddHuman(Human human, string sex, string profession, string subProperty) 
        {
            using (var context = new RationalityIntroDBEntities())
            {
                human.Sex = sex;
                human.Profession = profession;
                human.SubProperty = subProperty;

                context.Humen.Add(human);
                context.SaveChanges();
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
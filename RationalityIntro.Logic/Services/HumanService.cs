using RationalityIntro.Data;
using RationalityIntro.Data.DataModels;
using RationalityIntro.Logic.Dto;
using RationalityIntro.Logic.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalityIntro.Logic
{
    public interface IHumanService
    {
        List<HumanDto> GetHumans();

        HumanDto GetHumanById(int Id);

        void Delete(int? Id);

        int Add(Human human);
        
    }
    public class HumanService : IHumanService
    {
        private readonly HumanRepository humanRepository
            = new HumanRepository();

        public void Add(Human human)
        {

            var humanDomain = new Human
            {
                Id = human.Id,
                Sex = human.Sex,
                Profession = human.Profession,
                SubProperty = human.SubProperty,
                RelationsWithId = human.RelationsWithId
            };

            humanRepository.AddHuman(humanDomain);           
        }

        public void Delete(int? Id)
        {
            humanRepository.DeleteHuman(Id);
        }
                
        public HumanDto GetHumanById(int Id)
        {
            var human = humanRepository.GetHumanById(Id);

            return human.ToHumanDto();
        }

        public List<HumanDto> GetHumans()
        {
            var humanList = humanRepository.GetListOfHumans();

            return humanList.Select(x => x.ToHumanDto()).ToList();
        }

        int IHumanService.Add(Human human)
        {
            var humanDomain = new Human
            {
                Id = human.Id,
                Sex = human.Sex,
                Profession = human.Profession,
                SubProperty = human.SubProperty,
                RelationsWithId = human.RelationsWithId
            };

            humanRepository.AddHuman(humanDomain);
            return human.Id;
        }
    }
}

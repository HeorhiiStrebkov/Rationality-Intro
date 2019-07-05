using RationalityIntro.Data;
using RationalityIntro.Data.DataModels;
using RationalityIntro.Data.Repository;
using RationalityIntro.Logic.Dto;
using RationalityIntro.Logic.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalityIntro.Logic.Services
{
    public interface IActService
    {
        ActDto GetActById(int Id);
        void Delete(int Id);
        void Add(Act act);
    }
    public class ActService : IActService
    {
        private readonly ActRepository actRepository
            = new ActRepository();

        public void Add(Act act)
        {
            actRepository.AddAct(act);
        }

        public void Delete(int Id)
        {
            actRepository.DeleteAct(Id);
        }

        public ActDto GetActById(int Id)
        {
            var act = actRepository.GetActById(Id);

            return act.ToActDto();
        }
    }
}


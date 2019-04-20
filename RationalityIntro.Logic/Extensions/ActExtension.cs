using RationalityIntro.Data.DataModels;
using RationalityIntro.Logic.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalityIntro.Logic.Extensions
{
    public static class ActExtension
    {
        public static ActDto ToActDto(this Act act)
        {
            if (act == null)
                return null;

            var actDto = new ActDto
            {
                Id = act.Id,
                Description = act.Description

            };

            return actDto;
        }
    }
}

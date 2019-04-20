using RationalityIntro.Data.DataModels;
using RationalityIntro.Logic.Dto;
using System.Linq;

namespace RationalityIntro.Logic.Extensions
{
    public static class HumanExtension
    {
        public static HumanDto ToHumanDto(this Human human)
        {
            if (human == null)
                return null;

            var humanDto = new HumanDto
            {
                Id = human.Id,
                Sex = human.Sex,
                Profession = human.Profession,
                SubProperty = human.SubProperty,
                RelationsWithId =human.RelationsWithId
            };

            return humanDto;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalityIntro.Logic.Dto
{
    public class HumanDto
    {
        public int Id { get; set; }
        public string Sex { get; set; }
        public string Profession { get; set; }
        public string SubProperty { get; set; }
        public Nullable<int> RelationsWithId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalityIntro.Logic.Dto
{
    public class MessageDto
    {
        public int Id { get; set; }
        public Nullable<int> ActId { get; set; }
        public string Text { get; set; }
    }
}

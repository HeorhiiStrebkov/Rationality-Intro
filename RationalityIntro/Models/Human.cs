using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RationalityIntro.Models
{
    public class Human
    {
        public int Id { get; set; }
        public string Sex { get; set; }
        public string Profession { get; set; }
        public string SubProperty { get; set; }
        public int RelationsWithId { get; set; }
    }
}
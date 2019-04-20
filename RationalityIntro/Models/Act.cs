using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RationalityIntro.Models
{
    public class Act 
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public List<Human> AllPeople { get; set; }
        public List<Human> ChoosenPeople { get; set; } 
    }
}
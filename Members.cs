using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHeist
{
    internal class Member1
    {
        internal string Name { get; set; }
        internal int Skill { get; set; }
        internal decimal CourageFactor { get; set; }
        public Member1(string name, int skillLevel, decimal courageFactor)
        {
            this.Name = name;
            this.Skill = skillLevel;
            this.CourageFactor = courageFactor;
        }
    }

    internal class Member2
    {
        internal string Name { get; set; }
        internal int Skill { get; set; }
        internal decimal CourageFactor { get; set; }
        public Member2(string name, int skillLevel, decimal courageFactor)
        {
            this.Name = name;
            this.Skill = skillLevel;
            this.CourageFactor = courageFactor;
        }
    }
    internal class Member3 
    {
        internal string Name { get; set; }
        internal int Skill { get; set; }
        internal decimal CourageFactor { get; set; }
        public Member3(string name, int skillLevel, decimal courageFactor)
        {
            this.Name = name;
            this.Skill = skillLevel;
            this.CourageFactor = courageFactor;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heist
{
    internal class HeistMembers
    {
        //Member Names
        internal string MemberNameOne { get; set; }
        internal string MemberNameTwo { get; set; }
        internal string MemberNameThree { get; set; }
        internal List<string> Members = new();
        //Skill Levels
        internal string MemberOneSkillLevel { get; set; }
        internal string MemberTwoSkillLevel { get; set; }
        internal string MemberThreeSkillLevel { get; set; }
        internal List<int> SkillLevels = new();
        //Courage Levels
        internal decimal MemberOneCourage { get; set; }
        internal decimal MemberTwoCourage { get; set; }
        internal decimal MemberThreeCourage { get; set; }
        internal List<decimal> CourageLevels = new();
    }
}
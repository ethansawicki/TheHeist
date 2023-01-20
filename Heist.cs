using Heist;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;

namespace TheHeist
{
    internal class Heist
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Welcome to The Heist");
            var Member = new HeistMembers();
            //Also This seems wayy too much theres probably an easier way
            //First Member for Heist
            Console.Write("Please Enter Team Member Name One: ");
            Member.MemberNameOne = Console.ReadLine();
            
            while (String.IsNullOrWhiteSpace(Member.MemberNameOne))
            {
                Console.WriteLine("Please Enter A Valid Name: ");
                Member.MemberNameOne = Console.ReadLine();
            }
            
            Member.Members.Add(Member.MemberNameOne);

            //Second Member For Heist
            Console.Write("Please Enter Team Member Name Two: ");
            Member.MemberNameTwo = Console.ReadLine();

            while (String.IsNullOrWhiteSpace(Member.MemberNameTwo))
            {
                Console.WriteLine("Please Enter Valid Names: ");
                Member.MemberNameTwo = Console.ReadLine();
            }
            Member.Members.Add(Member.MemberNameTwo);

            //Third Member For Heist
            Console.Write("Please Enter Team Member Name Three: ");
            Member.MemberNameThree = Console.ReadLine();

            while (String.IsNullOrWhiteSpace(Member.MemberNameThree))
            {
                Console.WriteLine("Please Enter Valid Names: ");
                Member.MemberNameThree = Console.ReadLine();
            };
            Member.Members.Add(Member.MemberNameThree);

            //Skill Level Input One
            Console.Write("Please Enter Skill Level For Member One: ");
            Member.MemberOneSkillLevel = Console.ReadLine();
            int.TryParse(Member.MemberOneSkillLevel, out int SkillLvlOne);
            

            while(SkillLvlOne <= 0)
            {
                Console.WriteLine("Please enter a valid number");
                Member.MemberOneSkillLevel = Console.ReadLine();
                int.TryParse(Member.MemberOneSkillLevel, out SkillLvlOne);  
            }
            Member.SkillLevels.Add(SkillLvlOne);

            //Skill Level Input Two
            Console.Write("Please Enter Skill Level For Member Two: ");
            Member.MemberTwoSkillLevel = Console.ReadLine();
            int.TryParse(Member.MemberTwoSkillLevel, out int SkillLvlTwo);


            while (SkillLvlTwo <= 0)
            {
                Console.WriteLine("Please enter a valid number");
                Member.MemberTwoSkillLevel = Console.ReadLine();
                int.TryParse(Member.MemberTwoSkillLevel, out SkillLvlTwo);
            }
            Member.SkillLevels.Add(SkillLvlTwo);

            //Skill Level Input Three
            Console.Write("Please Enter Skill Level For Member One: ");
            Member.MemberThreeSkillLevel = Console.ReadLine();
            int.TryParse(Member.MemberThreeSkillLevel, out int SkillLvlThree);


            while (SkillLvlThree <= 0)
            {
                Console.WriteLine("Please enter a valid number");
                Member.MemberThreeSkillLevel = Console.ReadLine();
                int.TryParse(Member.MemberThreeSkillLevel, out SkillLvlThree);
            }
            Member.SkillLevels.Add(SkillLvlThree);

            Console.Write("Please Enter Courage Factor: ");
            string CourageLvl = Console.ReadLine();
            decimal.TryParse(CourageLvl, out decimal Courage);
            

            while(Courage < 0.1M || Courage > 2.0M)
            {
                Console.WriteLine("Please enter value between 0.1 and 2.0");
                CourageLvl = Console.ReadLine();
                decimal.TryParse(CourageLvl, out Courage);   
            }
            Member.CourageLevels.Add(Courage);

            foreach (string Names in Member.Members)
            {
                foreach (int Levels in Member.SkillLevels)
                {
                    foreach (decimal CourageLevel in Member.CourageLevels)
                    {
                        Console.WriteLine($"Heist Members Name: {Names}, Skill Level: {Levels}, Courage Factor: {CourageLevel}.");
                    }
                }
            }
        }
    }
}
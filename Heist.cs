using TheHeist;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;

namespace TheHeist
{
    internal class Heist
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your Heist");
            Console.Write("Please enter name for member one: ");
            string Member1Name = Console.ReadLine();
            while (String.IsNullOrEmpty(Member1Name))
            {
                Console.Write("Please Enter Valid Name: ");
                Member1Name = Console.ReadLine();
            }
            
            Console.Write("Please Enter Skill Level");
            string skillLvl = Console.ReadLine();
            int.TryParse(skillLvl, out int level);
            while(level <= 0) 
            {
                Console.Write("Please enter a valid number");
                int.TryParse(skillLvl, out level);
            }
            Console.Write("Please Enter Courage Factor: ");
            string courageFactor = Console.ReadLine();
            decimal.TryParse(courageFactor, out decimal Factor);
            while(Factor < 0.1M || Factor > 2.0M)
            {
                Console.Write("Please enter valid values between 0.0 and 2.0");
                courageFactor = Console.ReadLine();
                decimal.TryParse(courageFactor, out Factor);
            }
            var HeistMemberOne = new Member1(Member1Name, level, Factor);
            Console.WriteLine(HeistMemberOne.Name);
        }
    }
    
}
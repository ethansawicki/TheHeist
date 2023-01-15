using Heist;
namespace TheHeist
{
    internal class Heist
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Welcome to The Heist");
            var Member = new HeistMembers();

            Console.Write("Please Enter Your Name: ");
            Member.Name = Console.ReadLine();

            while(String.IsNullOrWhiteSpace(Member.Name))
            {
                Console.WriteLine("Please Enter Name: ");
                Member.Name = Console.ReadLine();
            }

            Console.Write("Please Enter Skill Level: ");
            string skill = Console.ReadLine();
            int.TryParse(skill, out int SkillLvl);
            Member.SkillLevel= SkillLvl;

            while(SkillLvl <= 0)
            {
                Console.WriteLine("Please enter a valid number");
                skill = Console.ReadLine();
                int.TryParse(skill, out SkillLvl);
            }

            Console.Write("Please Enter Courage Factor: ");
            string CourageLvl = Console.ReadLine();
            decimal.TryParse(CourageLvl, out decimal Courage);
            Member.CourageFactor = Courage;

            while(Courage < 0.1M || Courage > 2.0M)
            {
                Console.WriteLine("Please enter value between 0.1 and 2.0");
                CourageLvl = Console.ReadLine();
                decimal.TryParse(CourageLvl, out Courage);   
            }
            Console.WriteLine($"Heist Members Name: {Member.Name}, Skill Level: {Member.SkillLevel}, Courage Factor: {Member.CourageFactor}.");
        }
    }
}
using CS_Day2.Untils;
using CS_Day2.Enum;

namespace CS_Day2
{
    public class Program
    {
        static void Main(String[] args)
        {
            MembersUntil membersUntil = new MembersUntil();

            Console.WriteLine("Lists of gender:");
            var femaleMembers = membersUntil.Members.Where(m => m.Gender == Gender.Female);
            var maleMembers = membersUntil.Members.Where(m => m.Gender == Gender.Male);
            var otherMembers = membersUntil.Members.Where(m => m.Gender == Gender.Other);

            Console.WriteLine("Male list :");
            foreach (Member member in maleMembers)
            {
                Console.WriteLine($"\t{member.MembersInfo}");
            }

            Console.WriteLine("Female list :");
            foreach (Member member in femaleMembers)
            {
                Console.WriteLine($"\t{member.MembersInfo}");
            }

            Console.WriteLine("Other list :");
            foreach (Member member in otherMembers)
            {
                Console.WriteLine($"\t{member.MembersInfo}");
            }
            Console.WriteLine("-------------------------------------------------------------------------------------");

            Console.WriteLine("\nOldest member: ");
            var maxAge = membersUntil.Members.Max(m => m.Age);
            var maxAgeMember = membersUntil.Members.FirstOrDefault(member => member.Age == maxAge);
            Console.WriteLine($"\t{maxAgeMember.MembersInfo}");
            Console.WriteLine("-------------------------------------------------------------------------------------");

            Console.WriteLine("\nFull name of members: ");
            membersUntil.Members.ForEach(x => Console.WriteLine($"\t{x.LastName} {x.FirstName}"));
            Console.WriteLine("-------------------------------------------------------------------------------------");


            Console.WriteLine("\nLists of birth year: ");
            Console.WriteLine("Equal 2k:");
            membersUntil.Members.Where(member => member.DateOfBirth.Year == 2000).Select(x => x.MembersInfo).ToList().ForEach(y => Console.WriteLine($"\t{y}"));

            Console.WriteLine("\nGreater than 2k:");
            membersUntil.Members.Where(member => member.DateOfBirth.Year > 2000).Select(x => x.MembersInfo).ToList().ForEach(y => Console.WriteLine($"\t{y}"));

            Console.WriteLine("\nLess than 2k:");
            membersUntil.Members.Where(member => member.DateOfBirth.Year < 2000).Select(x => x.MembersInfo).ToList().ForEach(y => Console.WriteLine($"\t{y}"));
            Console.WriteLine("-------------------------------------------------------------------------------------");

            Console.WriteLine("\nFirst member who was born in Ha Noi: ");
            var result = membersUntil.Members.FirstOrDefault(member => member.BirthPlace.Equals("Ha Noi"));
            Console.WriteLine($"\t{result.MembersInfo}");
        }
    }
}
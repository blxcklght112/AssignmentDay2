using CS_Day2.Enum;

namespace CS_Day2
{
    public class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string BirthPlace { get; set; }
        public int Age { get { return DateTime.Now.Year - DateOfBirth.Year; } }
        public bool IsGraduated { get; set; }
        public string IsGrad
        {
            get
            {
                if (IsGraduated)
                {
                    return "Yes";
                }
                else return "No";
            }
        }
        public string MembersInfo
        {
            get
            {
                return String.Format($"{FirstName,-5} {LastName,-12} {Gender.ToString(),-10} {DateOfBirth,-15} {BirthPlace,-15} {Age,-5} {IsGrad}");
            }
        }
    }
}

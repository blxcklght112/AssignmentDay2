using CS_Day2.Enum;

namespace CS_Day2.Untils
{
    public class MembersUntil
    {
        public List<Member> Members;
        public MembersUntil()
        {
            Members = InitMembers();
        }
        private List<Member> InitMembers()
        {
            return new List<Member>{
                 new Member{
                    FirstName = "Loc",
                    LastName = "Pham Duc",
                    Gender = Gender.Male,
                    DateOfBirth = new DateTime(1999,01,12),
                    PhoneNumber = "0343428821",
                    BirthPlace = "Ha Noi",
                    IsGraduated = false
                },
                new Member{
                    FirstName = "Loc 2",
                    LastName = "Pham Duc",
                    Gender = Gender.Male,
                    DateOfBirth = new DateTime(2000,01,12),
                    PhoneNumber = "0343428821",
                    BirthPlace = "Ha Noi",
                    IsGraduated = false
                },
                new Member{
                    FirstName = "An",
                    LastName = "Nguyen Hai",
                    Gender = Gender.Female,
                    DateOfBirth = new DateTime(1989,12,03),
                    PhoneNumber = "0343428821",
                    BirthPlace = "Thai Nguyen",
                    IsGraduated = false
                },
                new Member{
                    FirstName = "An 2",
                    LastName = "Nguyen Hai",
                    Gender = Gender.Other,
                    DateOfBirth = new DateTime(1989,12,03),
                    PhoneNumber = "0343428821",
                    BirthPlace = "Thai Nguyen",
                    IsGraduated = false
                },
                new Member{
                    FirstName = "Nhung",
                    LastName = "Nguyen Hong",
                    Gender = Gender.Female,
                    DateOfBirth = new DateTime(2004,08,08),
                    PhoneNumber = "0343428821",
                    BirthPlace = "Thai Binh",
                    IsGraduated = false
                },
            };
        }
    }
}
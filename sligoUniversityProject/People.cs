namespace sligoUniversityProject
{
    public abstract class People
    {
        //properties
        public int IdNumber { get; set; }
        public int DateOfBirth { get; set; }
        public int PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        //constructors
        public People(int idNumber, int dateOfBirth, int phoneNumber, string firstName, string middleName, string lastName, string email)
        {
            IdNumber = idNumber;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Email = email;
        }

        public People()
        {
        }
    }

    public class Administration : People
    {

    }

    public class Teachers : People
    {

    }

    public class Students : People
    {

    }

    public class FullTimeStudents : Students
    {

    }

    public class PartTimeStudents : Students
    {

    }
}


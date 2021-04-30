using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sligoUniversityProject;
using System.Data.Entity;

namespace sligoUniversityProjectConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PeopleData db = new PeopleData();

            using (db)
            {

                People p22 = new People() { PersonType = "21", DateOfBirth = 1, Email = "21", FirstName ="21", ID = 21, LastName = "21", MiddleName="fulltime", PhoneNumber = 1};


                Console.WriteLine("created");

                

                db.Peoples.Add(p22);


                Console.WriteLine("added");

                db.SaveChanges();

                Console.WriteLine("Saved changes");
            }
        }
    }
}

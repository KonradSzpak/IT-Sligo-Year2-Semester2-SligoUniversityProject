using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace sligoUniversityProject
{
    public class People
    {
        public int ID { get; set; }
        public int DateOfBirth { get; set; }
        public int PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PersonType { get; set; }
        public string FullPartOnline { get; set; }
    }
    public class PeopleData : DbContext
    {
        public PeopleData() : base("MyPeopleData") { }

        public DbSet<People> Peoples { get; set; }
    }
}


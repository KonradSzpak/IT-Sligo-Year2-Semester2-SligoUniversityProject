using System;
using System.Windows;

namespace sligoUniversityProject
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string FName;
            string Mname;
            string Lname;
            string email;
            string typeofperson;
            string fullpartonline;



            


            FName = tbFName.Text;
            
            Mname = tbMName.Text;


            Lname = tbLName.Text;



            email = tbEmail.Text;
            

            if (rbAdmin.IsChecked == true)
            {
                typeofperson = "aministrator";
            }
            else if (rbStudent.IsChecked == true)
            {
                typeofperson = "student";
            }
            else
            {
                typeofperson = "teacher";
            }

            if (rbFullTime.IsChecked == true)
            {
                fullpartonline = "fulltime";
            }
            else if (rbPartTime.IsChecked == true)
            {
                fullpartonline = "parttime";
            }
            else
            {
                fullpartonline = "online";
            }


            PeopleData db = new PeopleData();

            using (db)
            {

                People p22 = new People() { Email = email, FirstName = FName, LastName = Lname, MiddleName = Mname, PersonType = typeofperson, FullPartOnline = fullpartonline };
                db.Peoples.Add(p22);
                db.SaveChanges();
            }

            this.Close();


        }
    }
}

using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace sligoUniversityProject
{

    public partial class MainWindow : Window
    {
        public PeopleData db = new PeopleData();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from p in db.Peoples
                        select p.FirstName;

            lbPeople.ItemsSource = query.ToList();
            //var result = query.ToList().First(); // thats how u do this
        }

        private void lbPeople_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedPerson = (string)lbPeople.SelectedItem;



            var query = (from p in db.Peoples
                         where p.FirstName == selectedPerson
                         select new
                         {
                             FirstName = p.FirstName,
                             MiddleName = p.MiddleName,
                             LastName = p.LastName,
                             DateOfBirth = p.DateOfBirth,
                             PhoneNumber = p.PhoneNumber,
                             Email = p.Email,
                             ID = p.ID,
                             Title = p.PersonType,
                             Type = p.FullPartOnline
                         });

            //var query1 = from p in db.Peoples
            //             where p.FirstName == selectedPerson
            //             select p.LastName;

            dgPersonalInfo.ItemsSource = query.ToList();

        }

        private void btnApply_Click(object sender, RoutedEventArgs e)
        {
            string searchValue;
            searchValue = tbSearch.Text;
            Convert.ToString(searchValue);
            var query = from p in db.Peoples
                        where (p.FirstName == searchValue || p.LastName == searchValue || p.MiddleName == searchValue || p.PersonType == searchValue)


                        select new
                        {
                            FirstName = p.FirstName,
                            MiddleName = p.MiddleName,
                            LastName = p.LastName,
                            DateOfBirth = p.DateOfBirth,
                            PhoneNumber = p.PhoneNumber,
                            Email = p.Email,
                            ID = p.ID,
                            Title = p.PersonType,
                            Type = p.FullPartOnline
                        };
            //var result = query.ToList().First(); // thats how u do this
            dgPersonalInfo.ItemsSource = query.ToList();
        }

        public void Reset1()
        {
            string selectedPerson = (string)lbPeople.SelectedItem;

            var query = (from p in db.Peoples
                         where p.FirstName == selectedPerson
                         select new
                         {
                             FirstName = p.FirstName,
                             MiddleName = p.MiddleName,
                             LastName = p.LastName,
                             DateOfBirth = p.DateOfBirth,
                             PhoneNumber = p.PhoneNumber,
                             Email = p.Email,
                             ID = p.ID,
                             Title = p.PersonType,
                             Type = p.FullPartOnline
                         });

            dgPersonalInfo.ItemsSource = query.ToList();
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (cbPartTime.IsChecked == true && cbFullTime.IsChecked == true && cbOnline.IsChecked == true)
            {
                var query = from p in db.Peoples
                            where (p.FullPartOnline == "online" || p.FullPartOnline == "parttime" || p.FullPartOnline == "fulltime")
                            select new
                            {
                                FirstName = p.FirstName,
                                MiddleName = p.MiddleName,
                                LastName = p.LastName,
                                DateOfBirth = p.DateOfBirth,
                                PhoneNumber = p.PhoneNumber,
                                Email = p.Email,
                                ID = p.ID,
                                Title = p.PersonType,
                                Type = p.FullPartOnline
                            };

                dgPersonalInfo.ItemsSource = query.ToList();
            }
            else if (cbPartTime.IsChecked == true && cbFullTime.IsChecked == true)
            {
                var query = from p in db.Peoples
                            where (p.FullPartOnline == "parttime" || p.FullPartOnline == "fulltime")
                            select new
                            {
                                FirstName = p.FirstName,
                                MiddleName = p.MiddleName,
                                LastName = p.LastName,
                                DateOfBirth = p.DateOfBirth,
                                PhoneNumber = p.PhoneNumber,
                                Email = p.Email,
                                ID = p.ID,
                                Title = p.PersonType,
                                Type = p.FullPartOnline
                            };

                dgPersonalInfo.ItemsSource = query.ToList();
            }
            else if (cbFullTime.IsChecked == true && cbOnline.IsChecked == true)
            {
                var query = from p in db.Peoples
                            where (p.FullPartOnline == "online" || p.FullPartOnline == "fulltime")
                            select new
                            {
                                FirstName = p.FirstName,
                                MiddleName = p.MiddleName,
                                LastName = p.LastName,
                                DateOfBirth = p.DateOfBirth,
                                PhoneNumber = p.PhoneNumber,
                                Email = p.Email,
                                ID = p.ID,
                                Title = p.PersonType,
                                Type = p.FullPartOnline
                            };

                dgPersonalInfo.ItemsSource = query.ToList();
            }
            else if (cbPartTime.IsChecked == true && cbOnline.IsChecked == true)
            {
                var query = from p in db.Peoples
                            where (p.FullPartOnline == "online" || p.FullPartOnline == "parttime")
                            select new
                            {
                                FirstName = p.FirstName,
                                MiddleName = p.MiddleName,
                                LastName = p.LastName,
                                DateOfBirth = p.DateOfBirth,
                                PhoneNumber = p.PhoneNumber,
                                Email = p.Email,
                                ID = p.ID,
                                Title = p.PersonType,
                                Type = p.FullPartOnline
                            };

                dgPersonalInfo.ItemsSource = query.ToList();
            }
            else if (cbPartTime.IsChecked == true)
            {
                var query = from p in db.Peoples
                            where (p.FullPartOnline == "parttime")
                            select new
                            {
                                FirstName = p.FirstName,
                                MiddleName = p.MiddleName,
                                LastName = p.LastName,
                                DateOfBirth = p.DateOfBirth,
                                PhoneNumber = p.PhoneNumber,
                                Email = p.Email,
                                ID = p.ID,
                                Title = p.PersonType,
                                Type = p.FullPartOnline
                            };

                dgPersonalInfo.ItemsSource = query.ToList();
            }
            else if (cbOnline.IsChecked == true)
            {
                var query = from p in db.Peoples
                            where (p.FullPartOnline == "online")
                            select new
                            {
                                FirstName = p.FirstName,
                                MiddleName = p.MiddleName,
                                LastName = p.LastName,
                                DateOfBirth = p.DateOfBirth,
                                PhoneNumber = p.PhoneNumber,
                                Email = p.Email,
                                ID = p.ID,
                                Title = p.PersonType,
                                Type = p.FullPartOnline
                            };

                dgPersonalInfo.ItemsSource = query.ToList();
            }
            else if (cbFullTime.IsChecked == true)
            {
                var query = from p in db.Peoples
                            where (p.FullPartOnline == "fulltime")
                            select new
                            {
                                FirstName = p.FirstName,
                                MiddleName = p.MiddleName,
                                LastName = p.LastName,
                                DateOfBirth = p.DateOfBirth,
                                PhoneNumber = p.PhoneNumber,
                                Email = p.Email,
                                ID = p.ID,
                                Title = p.PersonType,
                                Type = p.FullPartOnline
                            };

                dgPersonalInfo.ItemsSource = query.ToList();
            }
            else
                Reset1();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 add = new Window1();
            add.Show();

            using (db)
            {

                People p22 = new People() { PersonType = "21", DateOfBirth = 1, Email = "21", FirstName = "21", ID = 21, LastName = "21", MiddleName = "fulltime", PhoneNumber = 1 };


                Console.WriteLine("created");



                db.Peoples.Add(p22);


                Console.WriteLine("added");

                db.SaveChanges();

                Console.WriteLine("Saved changes");
            }
        }

        private void CheckBox_Click2(object sender, RoutedEventArgs e)
        {
            if (cbAdmin.IsChecked == true && cbStudent.IsChecked == true && cbTeacher.IsChecked == true)
            {
                var query = from p in db.Peoples
                            where (p.PersonType == "administrator" || p.PersonType == "student" || p.PersonType == "teacher")
                            select new
                            {
                                FirstName = p.FirstName,
                                MiddleName = p.MiddleName,
                                LastName = p.LastName,
                                DateOfBirth = p.DateOfBirth,
                                PhoneNumber = p.PhoneNumber,
                                Email = p.Email,
                                ID = p.ID,
                                Title = p.PersonType,
                                Type = p.FullPartOnline
                            };

                dgPersonalInfo.ItemsSource = query.ToList();
            }
            else if (cbTeacher.IsChecked == true && cbStudent.IsChecked == true)
            {
                var query = from p in db.Peoples
                            where (p.PersonType == "teacher" || p.PersonType == "student")
                            select new
                            {
                                FirstName = p.FirstName,
                                MiddleName = p.MiddleName,
                                LastName = p.LastName,
                                DateOfBirth = p.DateOfBirth,
                                PhoneNumber = p.PhoneNumber,
                                Email = p.Email,
                                ID = p.ID,
                                Title = p.PersonType,
                                Type = p.FullPartOnline
                            };

                dgPersonalInfo.ItemsSource = query.ToList();
            }
            else if (cbTeacher.IsChecked == true && cbAdmin.IsChecked == true)
            {
                var query = from p in db.Peoples
                            where (p.PersonType == "administrator" || p.PersonType == "teacher")
                            select new
                            {
                                FirstName = p.FirstName,
                                MiddleName = p.MiddleName,
                                LastName = p.LastName,
                                DateOfBirth = p.DateOfBirth,
                                PhoneNumber = p.PhoneNumber,
                                Email = p.Email,
                                ID = p.ID,
                                Title = p.PersonType,
                                Type = p.FullPartOnline
                            };

                dgPersonalInfo.ItemsSource = query.ToList();
            }
            else if (cbAdmin.IsChecked == true && cbStudent.IsChecked == true)
            {
                var query = from p in db.Peoples
                            where (p.PersonType == "administrator" || p.PersonType == "student")
                            select new
                            {
                                FirstName = p.FirstName,
                                MiddleName = p.MiddleName,
                                LastName = p.LastName,
                                DateOfBirth = p.DateOfBirth,
                                PhoneNumber = p.PhoneNumber,
                                Email = p.Email,
                                ID = p.ID,
                                Title = p.PersonType,
                                Type = p.FullPartOnline
                            };

                dgPersonalInfo.ItemsSource = query.ToList();
            }
            else if (cbAdmin.IsChecked == true)
            {
                var query = from p in db.Peoples
                            where (p.PersonType == "administrator")
                            select new
                            {
                                FirstName = p.FirstName,
                                MiddleName = p.MiddleName,
                                LastName = p.LastName,
                                DateOfBirth = p.DateOfBirth,
                                PhoneNumber = p.PhoneNumber,
                                Email = p.Email,
                                ID = p.ID,
                                Title = p.PersonType,
                                Type = p.FullPartOnline
                            };

                dgPersonalInfo.ItemsSource = query.ToList();
            }
            else if (cbStudent.IsChecked == true)
            {
                var query = from p in db.Peoples
                            where (p.PersonType == "student")
                            select new
                            {
                                FirstName = p.FirstName,
                                MiddleName = p.MiddleName,
                                LastName = p.LastName,
                                DateOfBirth = p.DateOfBirth,
                                PhoneNumber = p.PhoneNumber,
                                Email = p.Email,
                                ID = p.ID,
                                Title = p.PersonType,
                                Type = p.FullPartOnline
                            };

                dgPersonalInfo.ItemsSource = query.ToList();
            }
            else if (cbTeacher.IsChecked == true)
            {
                var query = from p in db.Peoples
                            where (p.PersonType == "teacher")
                            select new
                            {
                                FirstName = p.FirstName,
                                MiddleName = p.MiddleName,
                                LastName = p.LastName,
                                DateOfBirth = p.DateOfBirth,
                                PhoneNumber = p.PhoneNumber,
                                Email = p.Email,
                                ID = p.ID,
                                Title = p.PersonType,
                                Type = p.FullPartOnline
                            };

                dgPersonalInfo.ItemsSource = query.ToList();
            }
            else
                Reset1();
        }
    }
}


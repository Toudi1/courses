using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Configuration;

namespace LinqToSQL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        LinqToSqlDataClassesDataContext dataContext;

        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["LinqToSQL.Properties.Settings.TutorialDBConnectionString"].ConnectionString;
            dataContext = new LinqToSqlDataClassesDataContext(connectionString);
            InsertUniversities();
            InsertStudent();
        }

        public void InsertUniversities()
        {
            dataContext.ExecuteCommand("delete from University");

            University yale = new University();
            yale.Name = "Yale";
            dataContext.Universities.InsertOnSubmit(yale);

            University oxford = new University();
            oxford.Name = "Oxford";
            dataContext.Universities.InsertOnSubmit(oxford);

            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.Universities;
        }

        public void InsertStudent()
        {
            University yale = dataContext.Universities.First(un => un.Name.Equals("Yale"));
            University oxford = dataContext.Universities.First(un => un.Name.Equals("Oxford"));
            dataContext.ExecuteCommand("delete from Student");

            List<Student> students = new List<Student>();

            students.Add(new Student { Name = "John", Gender = "male", UniversityId = yale.Id });
            students.Add(new Student { Name = "Carla", Gender = "female", University = yale});
            students.Add(new Student { Name = "Jame", Gender = "male", University = oxford});
            students.Add(new Student { Name = "Leyla", Gender = "female", University = oxford});
            students.Add(new Student { Name = "Toni", Gender = "male", University = yale});

            dataContext.Students.InsertAllOnSubmit(students);

            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.Students;
        }
    }
}

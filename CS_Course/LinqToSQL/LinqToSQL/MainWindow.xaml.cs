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
            //InsertUniversities();
            //InsertStudent();
            //InsertLecture();
            //InsertStudenLectureAssociations();
            //GetUniversityOfToni();
            //GetTonisLectures();
            //GetAllStudentsFromeYale();
            //GetAllUniversitiesWiyhTransgenders();
            //AllLecturesOnOxford();
            //UpdateToni();
            //DeleteJame();
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
            students.Add(new Student { Name = "Jame", Gender = "trans-gender", University = oxford});
            students.Add(new Student { Name = "Leyla", Gender = "female", University = oxford});
            students.Add(new Student { Name = "Toni", Gender = "male", University = yale});

            dataContext.Students.InsertAllOnSubmit(students);

            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.Students;
        }

        public void InsertLecture()
        {
            dataContext.ExecuteCommand("delete from Lecture");

            List<Lecture> lectures = new List<Lecture>();
            lectures.Add(new Lecture { Name = "Math" });
            lectures.Add(new Lecture { Name = "Chemistry" });
            lectures.Add(new Lecture { Name = "Art" });

            dataContext.Lectures.InsertAllOnSubmit(lectures);

            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.Lectures;

        }

        public void InsertStudenLectureAssociations()
        {

            Student John = dataContext.Students.First(st => st.Name.Equals("John"));
            Student Carla = dataContext.Students.First(st => st.Name.Equals("Carla"));
            Student Jame = dataContext.Students.First(st => st.Name.Equals("Jame"));
            Student Leyla = dataContext.Students.First(st => st.Name.Equals("Leyla"));
            Student Toni = dataContext.Students.First(st => st.Name.Equals("Toni"));

            Lecture Math = dataContext.Lectures.First(lc => lc.Name.Equals("Math"));
            Lecture Chemistry = dataContext.Lectures.First(lc => lc.Name.Equals("Chemistry"));
            Lecture Art = dataContext.Lectures.First(lc => lc.Name.Equals("Art"));

            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = John, Lecture = Math });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Carla, Lecture = Math });

            StudentLecture slJame = new StudentLecture();
            slJame.Student = Jame;
            slJame.LectureId = Chemistry.Id;
            dataContext.StudentLectures.InsertOnSubmit(slJame);

            dataContext.ExecuteCommand("delete from StudentLecture");

            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Leyla, Lecture = Art });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Toni, Lecture = Art });

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.StudentLectures;


        }

        public void GetUniversityOfToni()
        {
            Student Toni = dataContext.Students.First(st => st.Name.Equals("Toni"));

            University TonisUniversity = Toni.University;

            List<University> universities = new List<University>();
            universities.Add(TonisUniversity);


            MainDataGrid.ItemsSource = universities;

        }
        public void GetTonisLectures()
        {
            Student Toni = dataContext.Students.First(st => st.Name.Equals("Toni"));

            var tonisLectures = from sl in Toni.StudentLectures select sl.Lecture;

            MainDataGrid.ItemsSource = tonisLectures;

        }
        public void GetAllStudentsFromeYale()
        {
            var stfYale = from student in dataContext.Students
                          where student.University.Name == "Yale"
                          select student;
            MainDataGrid.ItemsSource = stfYale;
        }
        public void GetAllUniversitiesWiyhTransgenders()
        {
            var transgenderUniversity = from student in dataContext.Students
                                        join university in dataContext.Universities
                                        on student.University equals university
                                        where student.Gender == "trans-gender"
                                        select university;
            MainDataGrid.ItemsSource = transgenderUniversity;
        }
        public void AllLecturesOnOxford()
        {
            var lecturesOnOxfort = from studentLecture in dataContext.StudentLectures
                                   join student in dataContext.Students
                                   on studentLecture.StudentId equals student.Id
                                   where student.University.Name == "Oxford"
                                   select studentLecture.Lecture;
            MainDataGrid.ItemsSource = lecturesOnOxfort;
        }
        public void UpdateToni()
        {
            Student Toni = dataContext.Students.FirstOrDefault(st => st.Name == "Toni");
            Toni.Name = "Antonio";
            
            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.Students;
        }
        public void DeleteJame()
        {
            Student Jame = dataContext.Students.FirstOrDefault(st => st.Name == "Jame");
            dataContext.Students.DeleteOnSubmit(Jame);
            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource= dataContext.Students;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQToObjectsAndQueryOperators
{
    internal class UniversityManager
    {
        public List<University> universities;
        public List<Studen> studens;

        // constructor
        public UniversityManager()
        {
            universities = new List<University>();
            studens = new List<Studen>();

            // Let's add some Universities 
            universities.Add(new University { Id = 1, Name = "Yele" });
            universities.Add(new University { Id = 2, Name = "Beijing Tech" });

            // Let's add some Students
            studens.Add(new Studen { Id = 1, Name = "Carla", Gender = "femal", Age = 17, UniversityId = 1 });
            studens.Add(new Studen { Id = 2, Name = "Toni", Gender = "male", Age = 21, UniversityId = 1 });
            studens.Add(new Studen { Id = 3, Name = "Frank", Gender = "male", Age = 22, UniversityId = 2 });
            studens.Add(new Studen { Id = 4, Name = "Leyla", Gender = "female", Age = 19, UniversityId = 2 });
            studens.Add(new Studen { Id = 5, Name = "James", Gender = "trans-gender", Age = 25, UniversityId = 2 });
            studens.Add(new Studen { Id = 6, Name = "Linda", Gender = "female", Age = 22, UniversityId = 2 });

        }

        public void MaleStudents()
        {
            IEnumerable<Studen> maleStudents = from student in studens where student.Gender == "male" select student;
            Console.WriteLine("Male - Students: ");

            foreach (Studen student in maleStudents)
            {
                student.Print();
            }
        }
        public void FemaleStudents()
        {
            IEnumerable<Studen> femaleStudents = from student in studens where student.Gender == "female" select student;
            Console.WriteLine("Female - Students: ");

            foreach (Studen student in femaleStudents)
            {
                student.Print();
            }
        }

        public void SortStudentsByAge()
        {
            var sortedStudents = from student in studens orderby student.Age select student;

            Console.WriteLine("Studnents sorted by age: ");

            foreach (Studen student in sortedStudents)
            {
                student.Print();
            }
        }

        public void AllStudentsFromBeijingTech()
        {
            IEnumerable<Studen> bjtStudent = from student in studens
                                             join university in universities on student.UniversityId equals university.Id
                                             where university.Name == "Beijing Tech"
                                             select student;

            Console.WriteLine("All Beijing Tech students:");

            foreach (Studen student in bjtStudent)
            {
                student.Print();
            }
        }

        public void AllStudentsFromGivenUniversityId(int universityId)
        {
            IEnumerable<University> selectedUniversity = from university in universities
                                                         where university.Id == universityId
                                                         select university;

            IEnumerable<Studen> selectedUniversityIdStudent = from student in studens
                                                              join university in universities on student.UniversityId equals university.Id
                                                              where university.Name == selectedUniversity.ElementAt(0).Name
                                                              select student;

            Console.WriteLine("All {0} students:", selectedUniversity.ElementAt(0).Name);

            foreach (Studen student in selectedUniversityIdStudent)
            {
                student.Print();
            }
        }

        public void AllStudentsFromThatUni(int Id)
        {
            IEnumerable<Studen> myStudents = from student in studens
                                             join university in universities on student.UniversityId equals university.Id
                                             where university.Id == Id
                                             select student;

            Console.WriteLine("Students from that uni {0}", Id);
            foreach (Studen studen in myStudents)
            {
                studen.Print();
            }
        }

        public void StudentAndUniversityNameCollection()
        {
            var newCollection = from student in studens
                                join university in universities on student.UniversityId equals university.Id
                                orderby student.Name
                                select new { StudentName = student.Name, UniversityName = university.Name };

            Console.WriteLine("new collection with students and their universities");
            foreach (var col in newCollection)
            {
                Console.WriteLine("{0} studies in {1}", col.StudentName, col.UniversityName);
            }
        }
    }
}

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
            studens.Add(new Studen { Id = 2, Name = "Frank", Gender = "male", Age = 22, UniversityId = 2 });
            studens.Add(new Studen { Id = 3, Name = "Leyla", Gender = "female", Age = 19, UniversityId = 2 });
            studens.Add(new Studen { Id = 4, Name = "James", Gender = "trans-gender", Age = 25, UniversityId = 2 });
            studens.Add(new Studen { Id = 5, Name = "Linda", Gender = "female", Age = 22, UniversityId = 2 });

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

    }
}

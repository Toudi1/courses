using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyDemo
{
    internal class Trainees:Employe
    {
        protected string WorkingHours { get; set; }
        protected string SchoolHours { get; set; }

        protected Trainees() { }

        public Trainees (string name, string firstName, double salary, string workingHours, string schoolHours)
        {
            //properties deriving from employe 
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;

            // trainie properties
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine("{0} is studing", this.Name);
        }
        public override void Work()
        {
            Console.WriteLine("Student {0} working hours are  {1}",this.FirstName, this.WorkingHours);
        }
    }
}

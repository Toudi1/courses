using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyDemo
{
    internal class Employe
    {
        protected string Name { get; set; }
        protected string FirstName { get; set; }
        protected double Salary { get; set; }

        public Employe()
        {

        }

        public Employe(string name, string firstName, double salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }

        public virtual void Work()
        {
            Console.WriteLine("{0} is working", this.FirstName);
        }

        public void Pause()
        {
            
        }

    }
}

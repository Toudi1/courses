using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyDemo
{
    internal class Boss:Employe
    {
        protected bool CompanyCar { get; set; }

        protected Boss()
        {

        }
        
        public Boss (string name, string firstName, double salary, bool companyCar)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
            this.CompanyCar = companyCar;
        }

        public void Lead()
        {
            Console.WriteLine("{0} is leading", this.FirstName);
        }
    }
}

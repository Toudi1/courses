using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    // blueprint of data type 
    internal class Human
    {
        //member varible
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;


        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public Human(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }

        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }



        //member
        public void IntroduceMyself()
        {
            if (age != 0 && eyeColor != null)
                Console.WriteLine("Hi, I'm {0} {1}, I have {2} eys and I'm {3} yers old.", firstName, lastName, eyeColor, age);
            else if (age != 0)
                Console.WriteLine("Hi, I'm {0} {1}. I'm {2} yers old.", firstName, lastName, age);
            else if (eyeColor != null)
                Console.WriteLine("Hi, I'm {0} {1}. I have {2} eys.", firstName, lastName, eyeColor);
            else
                Console.WriteLine("Hi, I'm {0} {1}.", firstName, lastName);
        }
    }
}

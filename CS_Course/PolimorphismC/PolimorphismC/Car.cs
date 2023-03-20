using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorphismC
{
    internal class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        public Car()
        {
            HP = 100;
            Color = "White";
        }
        public Car(int hp, string color)
        {
            this.Color = color;
            this.HP = hp;
        }


        public new void Details()
        {
            Console.WriteLine("The {0} car has {1} HP", this.Color, this.HP);
        }

        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired!");
        }
    }
}

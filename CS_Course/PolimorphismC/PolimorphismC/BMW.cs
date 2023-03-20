using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorphismC
{
    internal class BMW : Car
    {
        private string Brand = "BMW";

        public string Model { get; set; }

        public BMW()
        {
            HP = 100;
            Color = "White";

            Model = "M5";
        }
        public BMW(int hp, string color, string model):base(hp,color)
        {
            this.Color = color;
            this.HP = hp;

            this.Model = model;
        }

        public void Details()
        {
            Console.WriteLine("The {0} {1} {2} has {3} HP", this.Color, this.Brand, this.Model, this.HP);
        }
        public override void Repair()
        {
            Console.WriteLine("{0} was repaired!", this.Model);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorphismC
{
    internal class Audi: Car
    {
        private string Brand = "Audi";
        public string Model { get; set; }

        public Audi()
        {
            HP = 100;
            Color = "White";

            Model = "A2";
            Brand = "Audi";
        }
        public Audi(int hp, string color, string model)
        {
            this.Color = color;
            this.HP = hp;

            this.Model = model;
        }

        public new void Details()
        {
            Console.WriteLine("The {0} {1} {2} has {3} HP", this.Color, this.Brand, this.Model, this.HP);
        }
        public override void Repair()
        {
            Console.WriteLine("{0} was repaired!", this.Model);
        }

    }
}

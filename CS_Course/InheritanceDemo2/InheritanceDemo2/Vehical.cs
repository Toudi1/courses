using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo2
{
    internal class Vehical
    {
        public float Speed { get; set; }
        public string Color { get; set; }

        public Vehical()
        {
            Speed = 120f;
            Color = "White";
        }

        public Vehical (float speed, string color)
        {
            this.Speed = speed;
            this.Color = color;
        }
    }
}

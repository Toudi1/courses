﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo2
{
    internal class Furniture
    {
        public string Color { get; set; }
        public string Material{ get; set; }

        public Furniture ()
        {
            Color = "White";
            Material = "Wood";
        }

        public Furniture (string color, string material)
        {
            this.Color = color;
            this.Material = material;
        }
    }
}

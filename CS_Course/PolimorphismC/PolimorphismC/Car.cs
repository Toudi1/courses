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

        // has a relationship
        protected CarIDInfo carIDInfo = new CarIDInfo();

        public void SetCarIDInfo(int idNum, string owner)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine("The car has ID: {0} and its owner is: {1}", carIDInfo.IDNum, carIDInfo.Owner);
        }

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

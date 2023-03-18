using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo2
{
    internal class Car : Vehical, IDestroyable
    {
        //implementing the interface's property
        public string DestructionSound { get; set; }

        //creating a new property to store nearby objects that also will be destroyed
        public List<IDestroyable> DestroyablesNearby;

        public Car (float speed, string color)
        {
            this.Speed = speed;
            this.Color = color;
            DestructionSound = "CarExplosionSound.mp3";

            DestroyablesNearby = new List<IDestroyable>();
        }

        public void Destroy()
        {
            Console.WriteLine("Playing destruction sound {0}",DestructionSound);
            Console.WriteLine("Create fire");
            //go through all nearby destructable objects
            foreach (IDestroyable destroyable in DestroyablesNearby)
            {
                destroyable.Destroy();
            }
        }
    }
}

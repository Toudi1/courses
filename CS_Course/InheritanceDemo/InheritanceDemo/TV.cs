using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class TV : ElectricalDevice
    {
        public TV(bool isOn, string brand):base(isOn,brand)
        {

        }
        public void WatchTV()
        {
            //checks if TV is on
            if (IsOn)
            {
                //listen to TV
                Console.WriteLine("Watching the TV!");
            }
            else
            {
                //print error message
                Console.WriteLine("TV is swithed off, switch on the TV first");
            }
        }
    }
}

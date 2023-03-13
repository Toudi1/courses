using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Radio : ElectricalDevice
    {
        public Radio(bool isOn, string brand) : base(isOn,brand)
        {
            
        }

        public void ListenRadio()
        {
            //checks if radio is on
            if (IsOn)
            {
                //listen to radio
                Console.WriteLine("Listening to the Radio!");
            }else
            {
                //print error message
                Console.WriteLine("Radio is swithed off, switch on the radio first");
            }
        }
    }
}

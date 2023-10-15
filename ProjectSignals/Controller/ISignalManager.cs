using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectSignals.Controller;
using ProjectSignals.Model;

namespace ProjectSignals.Controller
{
    interface ISignalManager
    {
       

        public Digital CreateDigitalSignal() 
        {
            Console.WriteLine("Please insert the new Digital Signal");

            return null;
        }

        public Analog CreateAnalogSignal() 
        {
            Console.WriteLine("Please insert the new Analog Signal");

            return null;
        }

        public void DeleteSignal()
        {

        }

        public void ShowSignals() 
        {
            Console.WriteLine("This is the current list of the signals: ");
            //SignalManager.ShowSignals();
        }


    }
}

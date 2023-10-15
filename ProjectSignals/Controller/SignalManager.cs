using ProjectSignals.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSignals.Controller
{
    public class SignalManager
    {
        List<Signal> signalList; 

        public SignalManager()
        {
            signalList = new List<Signal>();
        }

        public Signal CreateDigitalSignal()
        {
            string name;
            name = Console.ReadLine();

            Digital digtalSignal = new Digital(name);

            DateTime time = DateTime.UtcNow;

            return digtalSignal;
        }
        public Signal  CreateAnalogSignal()
        {
            string name;
            name = Console.ReadLine();

            Analog analogSignal = new Analog(name);

            DateTime time = DateTime.UtcNow;

            return analogSignal;
        }
        public void AddSignal()
        {
            int option;
            Console.WriteLine("Select one\n" +
                "1- Digital\n" +
                "2- Analog");
            option = Convert.ToInt32(Console.ReadLine());

            if (option == 1)
            {
                signalList.Add(CreateDigitalSignal());
            }
            else
            {
                signalList.Add(CreateAnalogSignal());
            }
            
           
        }

        public void DeleteSignal()
        {

        }

        public  void ShowSignals()
        {
            foreach (Signal signal in signalList)
            {
                Console.WriteLine($"Name: {signal.Name}, Type: {signal.GetType().Name}");
            }
        }

        public void SaveSignal()
        {
            string path = @"C:\Users\Signals.txt";

            if (File.Exists(path))
            {
                File.Delete(path);
            }
            using (StreamWriter sw = File.CreateText(path))
            {
                foreach (Signal s in signalList)
                    sw.WriteLine(s.Name + " " + s.Data);
            }

        }
    }
}

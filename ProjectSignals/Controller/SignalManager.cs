using ProjectSignals.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjectSignals.Controller
{
    public class SignalManager
    {
        private List<Signal> signalList; 

        public List<Signal> SignalList { get => signalList; set => signalList = value; }

        
        
        public void AddDigitalSignal(string name)
        {
            bool signalExists = signalList.Any(s => s.Name == name);
            if (!signalExists)
            {
                signalList.Add(new Digital(name));
            }

        }
        public void AddAnalogSignal(string name)
        {
            bool signalExists = signalList.Any(s => s.Name == name);
            if (!signalExists) 
            {
                signalList.Add(new Analog(name));
            }


        }
        public void AddDigitalValue(string name, int value)
        {
            int signalIndex = signalList.FindIndex(s => s.Name == name);
            if (signalIndex == -1)
            {
                AddDigitalSignal(name);
            }

            if (signalList[signalIndex] is Digital)
            {

                if (value == 0 || value == 1) 
                { 
                    signalList[signalIndex].AddValue(value);


                }

                else
                {
                    throw new ArgumentException("El valor de 'data' debe ser 0 o 1 en una señal digital.");
                }
                
            }
            else
            {
                throw new InvalidOperationException("La señal existente no es una señal digital.");
            }

            
        }
        public void DeleteSignal(string name)
        {
            Signal signalToRemove = signalList.FirstOrDefault(s => s.Name == name);
            if (signalToRemove != null)
            {
                signalList.Remove(signalToRemove);
            }
        }
        public  void ShowSignals()
        {
            foreach (Signal signal in SignalList)
            {
                Console.WriteLine($"Name: {signal.Name}, Type: {signal.GetType().Name}");
            }
        }

        public void SaveSignal()
        {
            string path = @"C:\Users\Signal.txt";

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

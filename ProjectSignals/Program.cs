using ProjectSignals.Model;
using ProjectSignals.Controller;

namespace ProjectSignals
{
    public class Program
    {
        static void Main(string[] args)            
        {
            SignalManager signalManager = new SignalManager();
            FileManager fileManager = new FileManager();


            signalManager.AddAnalogValue("Lluvia", 0.5);
            signalManager.AddAnalogValue("Lluvia", 0.8);
            signalManager.AddAnalogValue("Lluvia", 0.3);
            signalManager.AddAnalogValue("Lluvia", 0.9);
            signalManager.AddAnalogValue("Lluvia", 0.2);

            signalManager.AddAnalogValue("Temperatura", 25.0);
            signalManager.AddAnalogValue("Temperatura", 24.5);
            signalManager.AddAnalogValue("Temperatura", 25.5);
            signalManager.AddAnalogValue("Temperatura", 24.0);
            signalManager.AddAnalogValue("Temperatura", 25.7);

            signalManager.AddAnalogValue("Viento", 10.5);
            signalManager.AddAnalogValue("Viento", 11.0);
            signalManager.AddAnalogValue("Viento", 10.2);
            signalManager.AddAnalogValue("Viento", 10.9);
            signalManager.AddAnalogValue("Viento", 11.5);

            signalManager.AddAnalogValue("Humedad", 60.0);
            signalManager.AddAnalogValue("Humedad", 61.2);
            signalManager.AddAnalogValue("Humedad", 59.8);
            signalManager.AddAnalogValue("Humedad", 61.0);
            signalManager.AddAnalogValue("Humedad", 59.5);

            signalManager.AddAnalogValue("Presión", 1013.2);
            signalManager.AddAnalogValue("Presión", 1013.5);
            signalManager.AddAnalogValue("Presión", 1013.0);
            signalManager.AddAnalogValue("Presión", 1013.8);
            signalManager.AddAnalogValue("Presión", 1013.3);

            signalManager.AddDigitalValue("Switch1", 1);
            signalManager.AddDigitalValue("Switch1", 0);
            signalManager.AddDigitalValue("Switch1", 1);
            signalManager.AddDigitalValue("Switch1", 0);
            signalManager.AddDigitalValue("Switch1", 1);

            signalManager.AddDigitalValue("Switch2", 0);
            signalManager.AddDigitalValue("Switch2", 1);
            signalManager.AddDigitalValue("Switch2", 0);
            signalManager.AddDigitalValue("Switch2", 1);
            signalManager.AddDigitalValue("Switch2", 0);

            signalManager.AddDigitalValue("Switch3", 1);
            signalManager.AddDigitalValue("Switch3", 1);
            signalManager.AddDigitalValue("Switch3", 0);
            signalManager.AddDigitalValue("Switch3", 0);
            signalManager.AddDigitalValue("Switch3", 1);

            signalManager.AddDigitalValue("Switch4", 0);
            signalManager.AddDigitalValue("Switch4", 1);
            signalManager.AddDigitalValue("Switch4", 0);
            signalManager.AddDigitalValue("Switch4", 1);
            signalManager.AddDigitalValue("Switch4", 0);

            signalManager.AddDigitalValue("Switch5", 1);
            signalManager.AddDigitalValue("Switch5", 0);
            signalManager.AddDigitalValue("Switch5", 1);
            signalManager.AddDigitalValue("Switch5", 0);
            signalManager.AddDigitalValue("Switch5", 1);

            List<Digital> digitalSignals = signalManager.FilterByType<Digital>();
            List<Analog> analogSignals = signalManager.FilterByType<Analog>();
            foreach (Digital digital in digitalSignals)
            {
                Console.WriteLine(digital.Name);
                foreach (Data data in digital.Data)
                {
                    Console.WriteLine($"Valor: {data.Value} Fecha: {data.TimeStamp}");
                }

            }
            foreach (Analog analog in analogSignals)
            {
                Console.WriteLine(analog.Name);
                foreach (Data data in analog.Data)
                {
                    Console.WriteLine($"Valor: {data.Value} Fecha: {data.TimeStamp}");
                }

            }

            Analog temperatura = (Analog)signalManager.FilterByName("Temperatura");
            temperatura.Avg();
            temperatura.MaximumData();
            temperatura.LowestData();


            //Digital switch1 = new Digital("Switch1");
            //Analog temp = new Analog("Temperatura");
            //temp.AddValue(10.3);
            //temp.AddValue(2);
            //temp.AddValue(3);
            //temp.AddValue(4);
            //switch1.AddValue(0);
            //switch1.AddValue(1);
            //switch1.AddValue(1);
            //switch1.AddValue(1);
            //switch1.AddValue(0);

            //Console.WriteLine(switch1.Data[1].TimeStamp);

            //int option;


            //    do 
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Singal managment app");

            //        Console.WriteLine("1- Show list of current signals\n" +
            //            "2- create new Digital signal\n" +
            //            "3- save signals in file\n" +
            //            "4- delete signal\n" +
            //            "5- show signal by name\n" +
            //            "6- show signal by type\n" +
            //            "7- show signal by date\n");
            //        option = Convert.ToInt32(Console.ReadLine());

            //        switch (option)
            //        {
            //            case 0:
            //                Console.Clear();
            //                Console.WriteLine("turning off");
            //                break;
            //            case 1:
            //                Console.Clear();
            //                Console.WriteLine("this are the current signals: ");
            //                signalManager.ShowSignals();
            //                break;
            //            case 2:
            //                Console.Clear();
            //                Console.WriteLine("you are going to add a new signal");
            //                signalManager.CreateDigitalSignal();
            //                break;
            //            case 3:
            //                Console.Clear();
            //                Console.WriteLine("Saving signals");
            //                signalManager.SaveSignal();
            //                break;
            //            case 4:
            //                Console.Clear();
            //                Console.WriteLine("you are going to delete a signal");    
            //                break;
            //            case 5:
            //                Console.Clear();
            //                Console.WriteLine("showing signal by name");
            //                break;
            //            case 6:
            //                Console.Clear();
            //                Console.WriteLine("showing signal by type");
            //                break;
            //            case 7:
            //                Console.Clear();
            //                Console.WriteLine("showing signal by date");
            //                break;
            //        }
            //    } while (option != 0);


        }
    }

}
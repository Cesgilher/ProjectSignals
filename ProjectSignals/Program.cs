using ProjectSignals.Model;
using ProjectSignals.Controller;
using ProjectSignals.Filter;

namespace ProjectSignals
{
    public class Program
    {
        static void Main(string[] args)
        {
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

            int option;
            SignalManager signalManager = new SignalManager();
            FileManager file = new FileManager();

                do 
                {
                    Console.Clear();
                    Console.WriteLine("Singal managment app");

                    Console.WriteLine("1- Show list of current signals\n" +
                        "2- create new Digital signal\n" +
                        "3- save signals in file\n" +
                        "4- delete signal\n" +
                        "5- show signal by name\n" +
                        "6- show signal by type\n" +
                        "7- show signal by date\n");
                    option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case 0:
                            Console.Clear();
                            Console.WriteLine("turning off");
                            break;
                        case 1:
                            Console.Clear();
                            Console.WriteLine("this are the current signals: ");
                            signalManager.ShowSignals();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("you are going to add a new signal");
                            signalManager.CreateDigitalSignal();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Saving signals");
                            signalManager.SaveSignal();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("you are going to delete a signal");    
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("showing signal by name");
                            break;
                        case 6:
                            Console.Clear();
                            Console.WriteLine("showing signal by type");
                            break;
                        case 7:
                            Console.Clear();
                            Console.WriteLine("showing signal by date");
                            break;
                    }
                } while (option != 0);
            

        }
    }

}
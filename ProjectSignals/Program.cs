using ProjectSignals.Model;
using ProjectSignals.Controller;
using ProjectSignals.Filter;

namespace ProjectSignals
{
    public class Program
    {
        static void Main(string[] args)
        {
            Digital switch1 = new Digital("Switch1");
            Analog temp = new Analog("Temperatura");
            temp.AddValue(10.3);
            temp.AddValue(2);
            temp.AddValue(3);
            temp.AddValue(4);
            switch1.AddValue(0);
            switch1.AddValue(1);
            switch1.AddValue(1);
            switch1.AddValue(1);
            switch1.AddValue(0);

            Console.WriteLine(switch1.Data[1].TimeStamp);

        }
    }

}
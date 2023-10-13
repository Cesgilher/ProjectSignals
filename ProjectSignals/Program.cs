using GestampSignals.Model;

namespace ProjectSignals
{
    public class Program
    {
        static void Main(string[] args)
        {
            Digital temp = new Digital("temperatura");

            temp.AddValue(1);
            temp.AddValue(2);
            temp.AddValue(3);
            temp.AddValue(4);

            
        }
    }

}
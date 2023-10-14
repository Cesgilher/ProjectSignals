using ProjectSignals.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSignals.Controller
{
    public class SignalManager : ISignalManager
{
    public List<Signal> signalList = new List<Signal>();

    public SignalManager() { }

    internal List<Signal> Signals { get => signalList; private set => signalList = value; }

    public Signal CreateDigitalSignal()
    {
        Signal s = new Digital();

        Console.WriteLine("Please insert the new Digital Signal");

        string name = Console.ReadLine();
        int value = Convert.ToInt16(Console.ReadLine());
        DateTime time = DateTime.Now;
        double switchOption = Convert.ToInt16(Console.ReadLine());

        s = new Digital();

        return s;
    }
    public Signal CreateAnalogSignal()
    {
        Signal s = new Analog();

        Console.WriteLine("Please insert the new Digital Signal");
        string name = Console.ReadLine();
        int value = Convert.ToInt16(Console.ReadLine());
        DateTime time = DateTime.Now;
        double temperature = Convert.ToDouble(Console.ReadLine());

        s = new Analog();

        return s;
    }
    public void AddSignal(Signal s)
    {
        if (s != null)
        {
            signalList.Add(s);
        }
    }

    public void DeleteSignal()
    {

    }

    public void ShowSignals()
    {
        foreach (Signal s in signalList)
        {
            if (s != null)
            {
                Console.WriteLine(" Name: " + s._Name + " Value: " + s._Value + " Time: " + s._Time);
            }
        }
    }
}
}

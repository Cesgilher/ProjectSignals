using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSignals.Model
{
    internal class Analog : Signal
    {
        public Analog(string name) 
        {
            this.Name = name;
        }


        

        public void MaximumData()
        {
            Data maxData = Data.Aggregate((max, current) => (max == null || current.Value > max.Value) ? current : max);
            Console.WriteLine( $"El valor máximo para está señal es: {maxData.Value} con fecha: {maxData.TimeStamp}");
            
        }

        public void LowestData()
        {
            Data minData = Data.Aggregate((min, current) => (min == null || current.Value < min.Value) ? current : min);
            Console.WriteLine($"El valor mínimo para está señal es: {minData.Value} con fecha: {minData.TimeStamp}");

        }
        

        public void Avg()
        {
            double averageValue = Data.Average(data => data.Value);
            Console.WriteLine( $"El valor medio para está señal es {averageValue}");
        }
    }
}

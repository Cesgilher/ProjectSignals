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


        public void AddValue(double data)
        {
            this.Data.Add(new Data(data));

        }

        public Data MaximumData()
        {
            Data maxData = Data.Aggregate((max, current) => (max == null || current.Value > max.Value) ? current : max);
            return maxData;
        }

        public Data LowestData()
        {
            Data minData = Data.Aggregate((min, current) => (min == null || current.Value > min.Value) ? current : min);
            return minData;
        }

        public void Avg()
        {
            double averageValue = Data.Average(data => data.Value);
            Console.WriteLine( $"El valor medio para está señal es {averageValue}");
        }
    }
}

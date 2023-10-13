using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSignals.Model
{
    public class Data
    {
        private double value;
        private DateTime timeStamp;

        public double Value { get => value; set => this.value = value; }
        public DateTime TimeStamp { get => timeStamp; set => timeStamp = value; }

       
        public Data(double value) 
        {
            this.value = value;
            this.timeStamp = DateTime.UtcNow;

        }

    }
}

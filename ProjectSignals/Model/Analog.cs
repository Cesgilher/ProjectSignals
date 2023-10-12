using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestampSignals.Model
{
    internal class Analog : Signal
    {
        private double _Temperature { get => _Temperature; set => _Temperature = value; }

        public Analog(string _Name, DateTime _Time) : this(_Name, 0.0, _Time)
        { }

        public Analog(string _Name, double _Temperature, DateTime _Time) : base(_Name, _Time)
        { 
            this._Temperature = _Temperature;

        }

        public override string ToString()
        {
            return $"Name: {_Name}, Temperature: {_Temperature}, Time {_Time}";
        }
    }
}

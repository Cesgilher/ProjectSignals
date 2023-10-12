using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestampSignals.Model
{
    public abstract class Signal
    {
        private string _Name {  get => _Name; set => _Name = value; }
        //private int _Value { get => _Value; set => _Value = value; }
        private DateTime _Time { get => _Time; set => _Time = value; }

        public Signal(string name, DateTime time)
        {
            _Name = name;
            //_Value = value;
            _Time = time;
        }

        public override string ToString()
        {
            return $"Name: {_Name}, Time: {_Time}";
        }
    }
}

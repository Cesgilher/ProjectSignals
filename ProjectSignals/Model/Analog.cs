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

    }
}

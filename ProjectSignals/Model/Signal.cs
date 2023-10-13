using ProjectSignals.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestampSignals.Model
{
    public abstract class Signal
    {   
        private string name;
        private List<Data> data = new List<Data>{};



        public string Name { get => name; set => name = value; }
        public List<Data> Data { get => data; set => data = value; }

        public void AddValue(int data)
        {
            this.Data.Add(new Data(data));

        }

        

    }
}

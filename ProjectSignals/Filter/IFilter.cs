using ProjectSignals.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSignals.Filter
{
    public interface IFilter
    {
        public Signal ByName(string name) {

            bool signalExists = signals.Any(s => s.Name == name);

            return null;
        }

        public List<Signal> ByType(string name) 
        {
            return null;
        }

        public List<Signal> ByDate(DateTime date)
        {
            return null;
        }
}

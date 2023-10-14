using ProjectSignals.Controller;
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
        public Signal ByName(SignalManager signalManager, string name) {

            Signal signal = signalManager.signalList.FirstOrDefault(s => s.Name == name);
            return signal;

        }

        public List<Signal> ByType(SignalManager signalManager, string type)
        {
            List<Signal> signals = signalManager.signalList.Where(s => s.GetType().Name == type).ToList();
            return signals;
        }
        public List<Signal> ByDate(SignalManager signalManager, DateTime time)
        {
            
        }


    }

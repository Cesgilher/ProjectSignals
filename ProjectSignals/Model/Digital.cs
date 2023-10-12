using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestampSignals.Model
{
    public class Digital : Signal
    {
        private SwitchValue _SwitchValue { get; set; }

        public Digital(string _Name, DateTime _Time) : this(_Name, default(SwitchValue) , _Time) 
        { }

        public Digital(string _Name, SwitchValue _SwitchValue, DateTime _Time) : base(_Name, _Time) 
        {

            this._SwitchValue = _SwitchValue;
           

        }

        public override string ToString()
        {
            return $"Name: {_Name}, SwitchValue: {_SwitchValue}, Time {_Time}";
        }
    }



}
    

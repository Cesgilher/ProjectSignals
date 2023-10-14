using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSignals.Model
{
    public class Digital : Signal
    {

        public Digital(string name) 
        { 
            this.Name = name;
            
        
        }

        public void AddValue(int data)
        {
            this.Data.Add(new Data(data));

        }
       

    }
}
    

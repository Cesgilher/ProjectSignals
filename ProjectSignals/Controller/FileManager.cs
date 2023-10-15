using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectSignals.Controller;
using ProjectSignals.Model;

namespace ProjectSignals.Controller
{
    public class FileManager
    {
        public void SaveSignals(List<Signal> signalList)
        {
            string path = @"C:\Users\Signal.txt";

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            using (StreamWriter sw = File.CreateText(path))
            {
                foreach (Signal s in signalList)
                {
                    sw.WriteLine(s.Name);
                    foreach (Data data in s.Data)
                    {
                        sw.WriteLine(data.Value + " " + data.TimeStamp);

                    }
                }



            }
        }
    }
}

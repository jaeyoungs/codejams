using Alice.CodeJamLib.DataStructures;
using Codejams.Library;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codejams.Google._2015.RoundA.Haircut
{
    class Program
    {
        private const string INPUT_FILE_PATH = "c:\\temp\\B-small-practice.in";
        private const string OUTPUT_FILE_PATH = "c:\\temp\\B-small-practice.out";

        static void Main(string[] args)
        {
            Inputs.Parse(INPUT_FILE_PATH);
            var num_of_test = Inputs.PopInt();

            for (int i = 0; i < num_of_test; i++)
            {
                var temp = Inputs.PopInts();
                var b = temp[0];
                var n = temp[1];
                var m = Inputs.PopInts();
                
                var l = m.Select((x)=>{
                    double remain = (n) % (double)x;
                    return remain / (double)x;
                }).ToList();

                var min = l.Min();

                int baber;
                for (baber = 0; baber < l.Count(); baber++)
                {
                    if (l[baber] == min)
                    {
                        break;
                    }
                }
                //Checker.Check("barber", baber + 1);
                Outputs.Add((baber+1).ToString());
            }

            Outputs.WriteToFileWithFormater(OUTPUT_FILE_PATH);
        }
    }
}

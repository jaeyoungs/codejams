using Codejams.Library;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codejams.Google._2015.RoundA.MushroomMonster
{
    class Program
    {
        private const string INPUT_FILE_PATH = "c:\\temp\\input.txt";
        private const string OUTPUT_FILE_PATH = "c:\\temp\\output.txt";

        static void Main(string[] args)
        {
            Inputs.Parse(INPUT_FILE_PATH);
            var num_of_test = Inputs.PopInt();

            for (int i = 0; i < num_of_test; i++)
            {
                var num_of_state = Inputs.PopInt();
                var plate_states = Inputs.PopInts();
                var result1 = Eat1(num_of_state, plate_states);
                var result2 = Eat2(num_of_state, plate_states);
                Outputs.Add(string.Format("{0} {1}", result1, result2));
            }

            Outputs.WriteToFileWithFormater(OUTPUT_FILE_PATH);
        }

        static int Eat1(int num_of_state, int[] plate_states)
        {
            var result = 0;
            for (int i = 0; i < num_of_state; i ++ )
            {
                if (i == 0) continue;
                var diff = plate_states[i] - plate_states[i - 1];
                if (diff < 0)
                {
                    result += -diff;
                }
            }
            return result;
        }

        static int Eat2(int num_of_state, int[] plate_states)
        {
            
            var ratio = 0;
            for (int i = 0; i < num_of_state; i++)
            {
                if (i == 0) continue;
                var diff = plate_states[i] - plate_states[i - 1];
                if (diff < 0)
                {
                    ratio = Math.Max(ratio, -diff);
                }
            }

            var result = 0;
            for (var i = 0; i < num_of_state - 1; i++)
            {
                if (ratio > plate_states[i])
                {
                    result += plate_states[i];
                }
                else
                {
                    result += ratio;
                }
            }

            return result;
        }
    }
}

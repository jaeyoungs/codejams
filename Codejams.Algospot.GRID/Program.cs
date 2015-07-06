using Codejams.Library;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        private const string INPUT_FILE_PATH = "c:\\temp\\input.txt";
        private const string OUTPUT_FILE_PATH = "c:\\temp\\output.txt";

        private static Dictionary<int, int> _f = new Dictionary<int, int>();

        static void Main(string[] args)
        {
            Inputs.Parse(INPUT_FILE_PATH);
            var num_of_test = Inputs.PopInt();
            for (int i = 0; i < num_of_test; i++)
            {
                var width = Inputs.PopInt();
                var num_of_cases = f(width);
                Outputs.Add(num_of_cases.ToString());
            }
            Outputs.WriteToFileWithIndex(OUTPUT_FILE_PATH);
        }

        static int f(int w)
        {
            if (_f.ContainsKey(w)) return _f[w];
            
            int result = 0;
            if (w == 0) result = 1;
            else if (w == 1) result = 1;
            else if (w == 2) result = 5;
            else if (w == 3) result = 11;
            else 
            {
                for (int i = 1; i <= w; i++)
                {
                    result += f(w - i) * u(i);
                }
            }
            _f[w] = result;
            return _f[w];
        }

        static int u(int w)
        {
            if (w == 0) return 0;
            else if (w == 1) return 1;
            else if (w == 2) return 4;
            else if (w % 2 == 0) return 3;
            else return 2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codejams.Library
{
    public static class Checker
    {
        public static void Check(string name, int test)
        {
            Debug.Write(String.Format("[{0}] {1}\n", name, test));
        }

        public static void Check(string name, int[] test)
        {
            Debug.WriteLine(String.Format("[{0}] {1}\n", name, string.Join(" ", test)));
        }

        public static void Check(IEnumerable<object> lines)
        {
            foreach (var line in lines)
            {
                Debug.WriteLine("\t {0}", line);
            }
        }

        public static void Check(string name, object input)
        {
            Check(name, new List<object> { input });
        }

        public static void Check(int[,] input)
        {
            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    Debug.Write(input[i, j] + " ");
                }
                Debug.Write("\n");
            }
        }

        public static void Check(double[,] input)
        {
            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    Debug.Write(input[i, j] + " ");
                }
                Debug.Write("\n");
            }
            Debug.Write("\n");
        }
    }
}

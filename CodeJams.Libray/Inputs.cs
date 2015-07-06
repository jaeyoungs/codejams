using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codejams.Library
{
    public static class Inputs
    {
        private static Queue<string> _queue;

        public static void Parse(string filePath)
        {
            var input = File.ReadLines(filePath);
            _queue = new Queue<string>(input);
        }

        public static string Pop()
        {
            return _queue.Dequeue();
        }

        public static int PopInt()
        {
            return int.Parse(_queue.Dequeue());
        }

        public static int[] PopInts()
        {
            var tokens = _queue.Dequeue().Split(' ');
            return tokens.Select((token) => int.Parse(token)).ToArray();
        }

        //public static int[][] PopMatrix(int row, int col)
        //{ 
            
        //}


        public static int[,] PopIntMatrix(int row, int col)
        {
            int[,] result = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                var items = Inputs.PopInts();

                for (int j = 0; j < col ; j ++ )
                {
                    result[i,j] = items[j];
                }
            }

            return result;
        }

        public static int[][] PopIntMatrixInJagged(int row, int col)
        { 
            int[][] result = new int[row][];
            for (int i = 0; i < row; i++)
            {
                result[i] = Inputs.PopInts();
            }
            return result;

        }
    }
}

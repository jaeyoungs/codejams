using Codejams.Library;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUMB3RS
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
                // parsing a case.
                var temp = Inputs.PopInts();
                var num_of_towns = temp[0];
                var days = temp[1];
                var prison = temp[2];
                var map = Inputs.PopIntMatrixInJagged(num_of_towns, num_of_towns);
                var num_of_samples = Inputs.PopInt();
                var samples = Inputs.PopInts();


                // create a board to record the posibility.
                var board = new double[days + 1][];
                for (int day = 0; day < days + 1; day++)
                {
                    board[day] = new double[num_of_towns];
                }
                board[0][prison] = 1.0d;


                for (int day = 0; day < days; day++)
                {
                    var towns = board[day]
                        .Select((p, t) => t)
                        .Where((t) => board[day][t] != 0);

                    foreach(var town in towns)
                    {
                        var adj_towns = map[town]
                            .Select((k,adj) => adj)
                            .Where((adj) => map[town][adj] != 0); 
                        
                        foreach (var adj_town in adj_towns)
                        {
                            board[day + 1][adj_town] += board[day][town] / adj_towns.Count();
                        }
                    }
                }

                var result = samples.Select((s) => board[days][s]);
                Outputs.Add(string.Join(" ", result));
            }

            Outputs.WriteToFile(OUTPUT_FILE_PATH);
        }
     }
}

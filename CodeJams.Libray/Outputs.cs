using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codejams.Library
{
    public static class Outputs
    {
        private static List<string> _output = new List<string>();

        public static void WriteToFileWithIndex(string filePath)
        {
            var index = 1;
            var ouputWithIndex = _output.Select((token) => string.Format("{0} {1}", index++ , token));
            WriteToFileInternal(filePath, ouputWithIndex);
        }

        public static void WriteToFileWithFormater(string filePath)
        {
            var index = 1;
            var ouputWithIndex = _output.Select((token) => string.Format("Case #{0}: {1}", index++, token)).ToList();
            WriteToFileInternal(filePath, ouputWithIndex);
        }

        public static void WriteToFile(string filePath)
        {
            WriteToFileInternal(filePath, _output);
        }

        private static void WriteToFileInternal(string filePath, IEnumerable<string> output)
        {
            Checker.Check(output);
            File.WriteAllLines(filePath, output);
        }

        public static void Add(string line)
        {
            _output.Add(line);
        }
    }
}

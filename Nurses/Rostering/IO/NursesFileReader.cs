# pragma warning disable 1591

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Nurses.Rostering.IO
{
    public class NursesFileReader
    {
        public static String[] readFile(INursesFile nursesFile)
        {
            var lines = System.IO.File.ReadAllLines(nursesFile.FullName);
            return new ArraySegment<string>(lines, 1, lines.Length - 1).Array;
        }
    }
}
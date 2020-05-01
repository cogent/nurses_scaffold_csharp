using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Nurses.Rostering.IO
{
    public class NursesFileReader
    {
        public static List<Nurse> readCSV(INursesFile nursesFile)
        {
            using (var csv = Factory.CreateCsvReader(nursesFile.OpenText()))
            {
                return csv.GetRecords<Nurse>().ToList();
            }
        }
    }
}
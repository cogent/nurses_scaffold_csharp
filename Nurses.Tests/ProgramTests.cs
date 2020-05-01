using Xunit;
using Moq;
using System;
using Nurses;
using Nurses.Rostering.IO;

namespace Nurses.Tests
{
    public class ProgramTests
    {
        private static DateTime _start = DateTime.Now;
        private static DateTime _end = _start.AddDays(+1);
        private static string _testFile = "../../../SampleData/two_nurses.csv";
        private static NursesFile _inputFile = new NursesFile(_testFile);

        [Fact]
        public static void Program_Main_WhenAllParamsAreValid_ReturnSuccess()
        {
            var returnCode = Program.Main(_start, _end, _inputFile);
            Assert.Equal((int)Program.ExitCode.Success, returnCode);
        }
    }
}
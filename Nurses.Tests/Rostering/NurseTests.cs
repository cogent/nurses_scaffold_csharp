using Xunit;
using Moq;
using Nurses.Rostering;

namespace Nurses.Tests.Rostering
{
    public class NurseTests
    {
        private static string name = "Natasha";
        private static string uid = "19ab7c";

        [Fact]
        public void Nurse_Uid_SetGet()
        {
            var nurse = new Nurse();
            nurse.uid = uid;

            Assert.Equal(nurse.uid, uid);
        }

        [Fact]
        public void Nurse_Name_SetGet()
        {
            var nurse = new Nurse();
            nurse.name = name;

            Assert.Equal(nurse.name, name);
        }
    }
}
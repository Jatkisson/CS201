using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Unit04LabProgram1UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Unit04LabProgram1.Program.ProcessDeposit(2.25, 1.00);
            Unit04LabProgram1.Program.ProcessDeposit(1.25, 1.00);
            Unit04LabProgram1.Program.ProcessDeposit(0.25, 0.10);
            Unit04LabProgram1.Program.ProcessDeposit(0.15, 0.10);
            Unit04LabProgram1.Program.ProcessDeposit(0.05, 0.10);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Unit04LabProgram1.Program.ProcessDeposit(1.50, 1.00);
            Unit04LabProgram1.Program.ProcessDeposit(0.50, 0.50);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Unit04LabProgram1.Program.ProcessDeposit(1.00, 1.00);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unit03LabProgram2;

namespace UnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //First Test
            ProcessInput.InputProcessor(5);

            //Second Test
            ProcessInput.InputProcessor(13);
        }
    }
}

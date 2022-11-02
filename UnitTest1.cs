using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace WordlePOM
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            POM pom = new POM();

            pom.OpenPage();

            pom.AcceptCookies();

            pom.CloseInstructions();

            Thread.Sleep(10000);

            pom.inputLetter("R");
            pom.inputLetter("A");
            pom.inputLetter("D");
            pom.inputLetter("I");
            pom.inputLetter("O");
            pom.inputLetter("Enter");

            pom.CheckElement();
        }
    }
}

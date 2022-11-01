using Microsoft.VisualStudio.TestTools.UnitTesting;

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

            pom.inputLetter();
        }
    }
}

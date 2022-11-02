using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WordlePOM
{
    public class POM
    {
        IWebDriver driver;
        public POM()
        {
            driver = new ChromeDriver();
        }
        public void OpenPage()
        {
            driver.Navigate().GoToUrl("https://www.nytimes.com/games/wordle/index.html");
        }

        public void AcceptCookies()
        {
            IWebElement element = driver.FindElement(By.Id("pz-gdpr-btn-accept"));

            element.Click();

        }

        public void CloseInstructions()
        {
            IWebElement element2 = driver.FindElement(By.ClassName("game-icon"));

            element2.Click();
        }

        public void inputLetter(string input)
        {
           Thread.Sleep(100);
            var xPathBuilder = new InputElementXPathBuilder();
            string path = xPathBuilder.GetXpathForInputItem(input);
            IWebElement element2 = driver.FindElement(By.XPath(path));
            element2.Click();

            
        }

        public void CheckElement()
        {
            const string letterNotInWord = "rgba(120, 124, 126, 1)";
            const string letterInWordWrongPosition = "rgba(201, 180, 88, 1)";

            string input = "I";
            Thread.Sleep(100);
            var xPathBuilder = new InputElementXPathBuilder();
            string path = xPathBuilder.GetXpathForInputItem(input);
            IWebElement element2 = driver.FindElement(By.XPath(path));

           
            input = "R";
            Thread.Sleep(100);
            path = xPathBuilder.GetXpathForInputItem(input);
            IWebElement element3 = driver.FindElement(By.XPath(path));

            string colour = element2.GetCssValue("background-color");

            colour = element3.GetCssValue("background-color");



        }
    }
}

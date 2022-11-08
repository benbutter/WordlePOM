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
        public const string letterNotInWord = "120, 124, 126, 1";
        public const string letterInWordWrongPosition = "201, 180, 88, 1";
        public const string letterIncORRECTPosition = "106, 170, 100, 1";

        public const string resultCorrectPosition = "Is in correct position";
        public const string resultIncorrectPosition = "Is in word but in incorrect position";
        public const string resultNotInWord = "Not in word";

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
            Thread.Sleep(10000);
        }

        public void inputLetter(string input)
        {
           Thread.Sleep(500);
            var xPathBuilder = new InputElementXPathBuilder();
            string path = xPathBuilder.GetXpathForInputItem(input);
            IWebElement element2 = driver.FindElement(By.XPath(path));
            element2.Click();

            
        }

        public string CheckLetter(string input)
        {
           
            Thread.Sleep(500);
            var xPathBuilder = new InputElementXPathBuilder();
            string path = xPathBuilder.GetXpathForInputItem(input);
            IWebElement element = driver.FindElement(By.XPath(path));
            string colour = element.GetCssValue("background-color");

            return ConvertResult(GetBetween(colour, "(", ")"));
        }

        public string GetBetween(string strSource, string strStart, string strEnd)
        {
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                int Start, End;
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }
            
            return "";
        }

        private string ConvertResult(string result)
        {
            if (result == POM.letterIncORRECTPosition)
            {
                return resultCorrectPosition;
            }
            else if (result == POM.letterInWordWrongPosition)
            {
                return resultIncorrectPosition;
            }

            else
            {
                return resultNotInWord;
            }
        }
    }


}

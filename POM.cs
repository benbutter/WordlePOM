using System;
using System.Collections.Generic;
using System.Text;
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

        public void inputLetter()
        {
            //IWebElement element2 = driver.FindElement(By.XPath("//<tagName>[text()='Q']"));
            //    IWebElement element2 = driver.FindElement(By.XPath("//input[@text='Q']"));
            //IWebElement element2 = driver.FindElement(By.LinkText("q"));

            //  IWebElement element2 = driver.FindElement(By.XPath(@"//*[@id="wordle - app - game"]/div[2]/div[1]/button[1]"));

            string path = "//*[@id=\"wordle-app-game\"]/div[2]/div[1]/button[1]";
            IWebElement element2 = driver.FindElement(By.XPath(path));
            //*[@id="wordle-app-game"]/div[2]/div[3]/button[1]
            //*[@id="wordle-app-game"]/div[2]/div[2]/button[1]
            element2.Click();
        }
    }
}

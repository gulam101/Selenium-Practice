using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

class EntryPoint
  {
     static void Main(string[] args)
     {
        //Initalise the client
        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl("www.google.com");

        Thread.Sleep(3000);

        driver.Quit();
     }
  }


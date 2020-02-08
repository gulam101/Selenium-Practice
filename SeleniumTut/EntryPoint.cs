using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

class EntryPoint
  {
     static void Main(string[] args)
     {
        //Initalise the chrome client
        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl("http://google.com");

        IWebElement element = driver.FindElement(By.Id("lga"));

        if(element.Displayed)
        {
            System.Console.WriteLine("Hello World!");
        }

        //Shows for 3 seconds
        Thread.Sleep(3000);

        //Quits the application
        driver.Quit();
     }
  }


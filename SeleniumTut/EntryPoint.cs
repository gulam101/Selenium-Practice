using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

class EntryPoint
  {
     static void Main(string[] args)
     {
        //URL link
        string URLlink = "http://google.com";

        //Initalise the chrome client
        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl(URLlink);

        IWebElement element = driver.FindElement(By.Id("lga"));

        if(element.Displayed)
        {
            GreenMessage("You can see this message!");
        } else
        {
            //Warning message
            RedMessage("Well, something went wrong!");
        }

        //Quits the application
        driver.Quit();
     }

    public static void RedMessage(string message)
    {
        //Should display this if it works!
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ResetColor();
    }


    public static void GreenMessage(string message)
    {
        //Incorrect message!
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ResetColor();
    }


}


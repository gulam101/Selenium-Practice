using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

class ClassName
{
    static void Main(string[] args)
    {
        string URLlink = "http://testing.todorvachev.com/selectors/class-name/";
        string className = "testClass";

        //Initalise the chrome client
        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl(URLlink);

        IWebElement element = driver.FindElement(By.ClassName(className));

        //Calling the elements text
        Console.WriteLine(element.Text);

        //Quits the application
        driver.Quit();
    }
}


using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

class ClassName
{
    /* Quick Note!
     * In inspector using "Copy Selector" gives you CSS path
     * XPath can be used to navigate through elements 
     * and attributes in an XML document
     */

    static void Main(string[] args)
    {
        string URLlink = "http://testing.todorvachev.com/selectors/class-name/";
        string cssPath = "#post-108 > div > figure > img";
        string xPath = "//*[@id=\"post-108\"]/div/figure/img";
        string className = "testClass";

        //Initalise the chrome client
        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl(URLlink);

        //Creates our var called element
        //Then it finds the elemnt called "ClassName"
        IWebElement element = driver.FindElement(By.ClassName(className));

        //Calls the element text
        Console.WriteLine(element.Text);

        //Quits the application
        driver.Quit();
    }
}


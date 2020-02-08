﻿using OpenQA.Selenium;
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
            System.Console.ForegroundColor = System.ConsoleColor.Green;
            System.Console.WriteLine("Hello World!");
        } else
        {
            System.Console.ForegroundColor = System.ConsoleColor.Red;
            System.Console.WriteLine("Well, something went worng!");
        }

        //Quits the application
        driver.Quit();
     }
  }


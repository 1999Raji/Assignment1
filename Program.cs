using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using OpenQA.Selenium.Support.UI;
using System.Linq;
using System.Xml.Linq;
using OpenQA.Selenium.Interactions;

namespace Assignment1
{
    public class Program
    {
        static IWebDriver driver = new ChromeDriver();
        private static object elementCount;
        private static object drop;

        public static object Assert { get; private set; }

        static void Main()
        {
            String url = "http://www.qaclickacademy.com/practice.php ";
            driver.Navigate().GoToUrl(url);
            excercise1();
            execercise2();
            execercise3();
            execercise4();
            excercise5();
            exercise6();
            exercise7();
            exercise8();
            exercise9();



        }
        public static void excercise1()
        {

            IWebElement Option1 = driver.FindElement(By.XPath("//*[@id=\"radio-btn-example\"]/fieldset/label[1]/input"));
            Option1.Click();
            if (Option1.GetAttribute("checked") == "true")
            {
                Console.WriteLine("Option1 is selected");
            }
            else
            {
                Console.WriteLine("Not selected");
            }
            Thread.Sleep(3000);

            IWebElement Option2 = driver.FindElement(By.XPath("//*[@id=\"radio-btn-example\"]/fieldset/label[2]/input"));
            Option2.Click();
            if (Option2.GetAttribute("checked") == "true")
            {
                Console.WriteLine("Option2 is selected");
            }
            else
            {
                Console.WriteLine("Not selected");
            }
            Thread.Sleep(3000);

            IWebElement Option3 = driver.FindElement(By.XPath("//*[@id=\"radio-btn-example\"]/fieldset/label[3]/input"));
            Option3.Click();
            if (Option3.GetAttribute("checked") == "true")
            {
                Console.WriteLine("Option3 is selected");
            }
            else
            {
                Console.WriteLine("Not selected");
            }
            Thread.Sleep(3000);
        }

        public static void execercise2()
        {
            IWebElement selection = driver.FindElement(By.Id("autocomplete"));
            selection.SendKeys("united");
            IList<IWebElement> su = driver.FindElements(By.XPath(" //*[@id=\"autocomplete\"]"));
            foreach (var uelement in su)
            {
                if (uelement.Text.Contains("united states (USA)"))
                {
                    uelement.Click();

                }
            }

        }
        public static void execercise3()
        {
            IWebElement element = driver.FindElement(By.Id("dropdown-class-example"));
            SelectElement drop = new SelectElement(element);
            int[] options = { 0, 1, 2, 3 };
            foreach (var item in options)
            {
                drop.SelectByIndex(item);
                Thread.Sleep(2000);
            }



        }
        public static void execercise4()
        {
            //string option1 = "1";
            IWebElement CBox1 = driver.FindElement(By.XPath("//*[@id=\"checkBoxOption1\"]"));
            CBox1.Click();
            Console.WriteLine("Box1 is checked");
            Thread.Sleep(2000);

            //Box1 is Unchecked
            IWebElement uncheck1 = driver.FindElement(By.CssSelector("#checkBoxOption1"));
            uncheck1.Click();
            Console.WriteLine("Box1 is unchecked");
            Thread.Sleep(2000);

            //Box2 is selected
            IWebElement CBox2 = driver.FindElement(By.XPath("//*[@id=\"checkBoxOption2\"]"));
            CBox2.Click();
            Console.WriteLine("Box2 is checked");
            Thread.Sleep(2000);

            //Box2 is Unchecked
            IWebElement uncheck2 = driver.FindElement(By.CssSelector("#checkBoxOption2"));
            uncheck2.Click();
            Console.WriteLine("Box2 is unchecked");
            Thread.Sleep(2000);

            //Box3 is selected
            IWebElement CBox3 = driver.FindElement(By.XPath("//*[@id=\"checkBoxOption3\"]"));
            CBox3.Click();
            Console.WriteLine("Box3 is checked");
            Thread.Sleep(2000);

            //Box2 is Unchecked
            IWebElement uncheck3 = driver.FindElement(By.CssSelector("#checkBoxOption3"));
            uncheck3.Click();
            Console.WriteLine("Box3 is unchecked");
            Thread.Sleep(2000);

            for (int i = 1; i <= 3; i++)
            {
                IWebElement checkall = driver.FindElement(By.Id("checkBoxOption" + i + ""));
                checkall.Click();
                //Thread.Sleep(2000);
            }
        }
        public static void excercise5()
        {
            IWebElement window = driver.FindElement(By.Id("openwindow"));
            window.Click();
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Thread.Sleep(2000);


        }


        public static void exercise6()
        {
            IWebElement open = driver.FindElement(By.Id("opentab"));
            open.Click();
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Thread.Sleep(2000);

        }

        public static void exercise7()
        {
            IWebElement alertbutton = driver.FindElement(By.Id("name"));
            alertbutton.Click();
            alertbutton.SendKeys("John");
            Thread.Sleep(2000);
            
            IWebElement alert = driver.FindElement(By.Id("alertbtn"));
            alert.Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Alert().Accept();
            

        }
        public static void exercise8()
        {
            IWebElement table = driver.FindElement(By.Id("product"));
            table.Click();
            Actions actions = new Actions(driver);
            actions.SendKeys(OpenQA.Selenium.Keys.End).Build().Perform();
        }

        public static void exercise9()
        {
            var element = driver.FindElement(By.Id("mousehover"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(element).Perform();
            Thread.Sleep(2000);
            IWebElement top = driver.FindElement(By.CssSelector("body > div:nth-child(6) > div > fieldset > div > div > a:nth-child(1)"));
            actions.MoveToElement(top).Perform();
            top.Click();
            Thread.Sleep(2000);

        }
    }

}














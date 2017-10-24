using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace Console_Aplication
{
    public class Functions 
    {
        public static string path = @"C:\Users\Orjon.Cura\source\repos\CrisesControlAuto\CrisesControlAuto - " + DateTime.Now.DayOfWeek.ToString() + "-" + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString() + " - " + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + ".txt";
        public static int TimeSleep = 100;
        public static int Loop = 10000;

        public static void Click(String xpath){
            for (int x = 0; x < Loop; x++)
            {
                try
                {
                    IWebElement element = Constant.driver.FindElement(By.XPath(xpath));
                    if (element.Displayed && element.Enabled)
                    {
                        element.Click();
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.Write(e);
                    Thread.Sleep(TimeSleep);
                }
            }
         }
        public static void ClickCSS(String selector)
        {
            for (int x = 0; x < Loop; x++)
            {
                try
                {
                    IWebElement element = Constant.driver.FindElement(By.CssSelector(selector));
                    if (element.Displayed && element.Enabled)
                    {
                        element.Click();
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.Write(e);
                    Thread.Sleep(TimeSleep);
                }
            }
        }

        public static void SendKeys(String xpath, String text)
        {
            for (int y = 0; y < Loop; y++)
            {
                try
                {
                    IWebElement element = Constant.driver.FindElement(By.XPath(xpath));
                    if (element.Displayed && element.Enabled)
                    {
                        Clear(xpath);
                        element.SendKeys(text);
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.Write(e);
                    Thread.Sleep(TimeSleep);
                }
            }
        }

        public static void Clear(String xpath)
        {
            for (int y = 0; y < Loop; y++)
            {
                try
                {
                    IWebElement element = Constant.driver.FindElement(By.XPath(xpath));
                    if (element.Displayed && element.Enabled)
                    {
                        element.Clear();
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.Write(e);
                    Thread.Sleep(TimeSleep);
                }
            }
        }

        public static void txt(String text)
        {
            string ExistingText = "";
            if (!File.Exists(path))
            {
                File.Create(path).Dispose();
                using (StreamWriter tw = new StreamWriter(path))
                {
                    tw.WriteLine();
                    tw.Close();
                }

            }
            else
            {
                ExistingText = System.IO.File.ReadAllText(path) + "\n";
            }
            using (TextWriter tw = new StreamWriter(path))
            {
                tw.WriteLine(ExistingText + text);
                tw.Close();
            }

        }

        public static void Feedback(Action function,String text2)
        {
            DateTime a = DateTime.Now;
            Constant.text += text2 + "\r\n" + "Started At " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString() + "\r\n";

           function();

            for (int y = 0; y < 100; y++)
                {
                    try
                    {
                        Constant.text += "Result = " + Constant.driver.FindElement(By.XPath("//div[contains(@class, 'sweet-alert showSweetAlert visible')]/h2")).Text + "\r\n";
                        Constant.text += "Result = " + Constant.driver.FindElement(By.XPath("//div[contains(@class, 'sweet-alert showSweetAlert visible')]/p")).Text + "\r\n";
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.Write(e);
                        Thread.Sleep(TimeSleep);
                    }
                }

            Constant.text += "Fineshed At " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString()+ "\r\n";
            Constant.text += "Duration : " + (DateTime.Now - a ) + "\r\n" + "\r\n";

        }

        public static void Table(String table, String TD, String name)
        {

            IWebElement tableElement = Constant.driver.FindElement(By.XPath(table));
            IList <IWebElement> tableRow = tableElement.FindElements(By.TagName("tr"));
            IWebElement rowTD;
            for (int x = 0; x < Loop; x++)
            {
                try
                {
                        rowTD = Constant.driver.FindElement(By.XPath(TD));

                        if (rowTD.Text.Equals(name))
                        {
                            break;
                        }
                    
                }
                catch (Exception e)
                {
                    Console.Write(e);
                    Thread.Sleep(TimeSleep);
                }
            }
        }

        public static void Del()
        {
            Click("//a[contains(@class,\"btn btn-sm btn-small btn-danger\")]");

            if (Displayed("//div[contains(@class, 'sweet-alert showSweetAlert visible')]" ))
            {
                Click("//button[contains(text(),'Delete')]");
                for (int j = 0; j < Loop; j++)
                {
                    if (!(Constant.driver.FindElement(By.XPath("//div[contains(@class, 'sweet-alert showSweetAlert visible')]/h2")).Text.Equals("Delete Confirmation")))
                    {
                        break;
                    }
                }
            }  
            
        }

        public static bool Displayed(string xpath )
        {
            for (int x = 0; x < Loop; x++)
            {
                try
                {
                    if (Constant.driver.FindElement(By.XPath(xpath)).Enabled && Constant.driver.FindElement(By.XPath(xpath)).Displayed)
                    {
                        return true;
                    }
                }
                catch (Exception e)
                {
                    Console.Write(e);
                    Thread.Sleep(TimeSleep);
                }
            }
            return false;
        }
        public static void CheckURl(String url)
        {
            while (Constant.driver.Url != Constant.baseUrl + url)
            {
                Constant.driver.Navigate().GoToUrl(Constant.baseUrl + url);
            }
        }
    }
}
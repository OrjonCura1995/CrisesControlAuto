using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Console_Aplication
{
    public class Ping : Constant
    {
        public static void Create()
        {
             CheckURl("/ping/newping");


             SendKeys("//input[contains(@placeholder, 'Location')]", TestLocation + Keys.Enter);

             SendKeys("//input[contains(@placeholder, 'Users')]", UserNumber1 + Keys.Enter);

             Click("//textarea[contains(@id, 'Message')]");
             SendKeys("//textarea[contains(@id, 'Message')]", "Test Ping with Audio Attachment");

             Click("//span[contains(text(),\"Select\")]");
             Click("//li[contains(text(),\"Low\")]");

             Click("//a[contains(@data-cmd, \"pingaudiomessage\")]");

             Click("//span[contains(text(), \"test\")]");

             Click("//button[contains(@id, 'btn_submit')]");

        }

        public static void Acknowledge()
        {
             CheckURl("/ping/view");

            bool found2 = true;
            for (int x = 0; x < 20; x++) {

                IWebElement element = driver.FindElement(By.XPath("//span[contains(@id,'chat-message-count')]"));
                IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
                executor.ExecuteScript("arguments[0].click();", element);
                IWebElement element2 = driver.FindElement(By.XPath("//a[contains(@href, '#tabPingMessage')]"));
                IJavaScriptExecutor executor2 = (IJavaScriptExecutor)driver;
                executor2.ExecuteScript("arguments[0].click();", element2);

                try {
                    Thread.Sleep(2000);
                    driver.FindElement(By.XPath("//button[contains(@class, 'btn btn-block btn-success rspndBtn')]"));
                    Thread.Sleep(2000);
                } catch (Exception e) {
                    Console.WriteLine(e);
                    found2 = false;
                }

                if (!found2) {
                    found2 = false;
                    Thread.Sleep(2000);
                     Click("//a[contains(@class, 'reload')]");
                }

                if (found2) {
                    IWebElement element3 = driver.FindElement(By.XPath("//button[contains(@class, 'btn btn-block btn-success rspndBtn')]"));
                    IJavaScriptExecutor executor3 = (IJavaScriptExecutor)driver;
                    executor3.ExecuteScript("arguments[0].click();", element3);
                    driver.FindElement(By.XPath("//a[contains(@class, 'reload')]")).Click();
                    driver.Navigate().GoToUrl( baseUrl + "/ping/");
                     
                    break;
                } else {
                    found2 = true;
                }

            }
            Thread.Sleep(1000);

            IWebElement element4 = driver.FindElement(By.XPath("//div[contains(@class, 'progress-bar acklist progress-bar-success')]"));
            IJavaScriptExecutor executor4 = (IJavaScriptExecutor)driver;
            executor4.ExecuteScript("arguments[0].click();", element4);
        }
    }
}

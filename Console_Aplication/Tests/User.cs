using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Console_Aplication
{
    public class User : Constant
    {
        public static void Create()
        {

            CheckURl("/users");
             
             Click("//button[contains(@class,\"btn btn-success dropdown-toggle\")]");
             Click("//a[contains(@href,\"" + baseUrl + "/users/create\")]");

             SendKeys("//input[contains(@id,\"FirstName\")]", "Automated");
             SendKeys("//input[contains(@id,\"Email\")]", "Test@test.com");
             SendKeys("//input[contains(@id,\"LastName\")]", "Testuser");
             SendKeys("//input[contains(@id,\"Mobile\")]", "7274576037");

             Click("//button[contains(@id,\"btn_submit\")]");


            if (Displayed("//div[contains(@class, 'sweet-alert showSweetAlert visible')]"))
            {
                for (int j = 0; j < 100; j++)
                {
                    if (driver.FindElement(By.XPath("//div[contains(@class, 'sweet-alert showSweetAlert visible')]/h2")).Text.Equals("License Warning"))
                    {
                            Click("//button[contains(@class,'confirm')]");
                        for (int i = 0; i < 100; i++)
                        {
                            if (!(driver.FindElement(By.XPath("//div[contains(@class, 'sweet-alert showSweetAlert visible')]/h2")).Text.Equals("License Warning")))
                            {
                                break;
                            }
                        }
                        break;
                    }
                }

            }

        }
        public static void Edit()
        {
             CheckURl("/users");

             SendKeys("//input[contains(@class, \"form-control input-inline\")]", "Automated Testuser");

             Table("//*[@id=\"tblUsers\"]", "//*[@id=\"tblUsers\"]/tbody/tr[1]/td[2]", "Automated Testuser");
             Click("//a[contains(@class,'btn btn-sm btn-small btn-warning')]");

             SendKeys("//input[contains(@id,\"FirstName\")]", "Orjon's Automated");

             Click("//button[contains(@id,\"btn_submit\")]");

            for (int x = 0; x < 100; x++)
            {
                try
                {
                    if (driver.FindElement(By.XPath("//div[contains(@class, 'sweet-alert showSweetAlert visible')]")).Enabled)
                    {
                        for (int j = 0; j < 100; j++)
                        {
                            if (driver.FindElement(By.XPath("//div[contains(@class, 'sweet-alert showSweetAlert visible')]/h2")).Text.Equals("License Warning"))
                            {
                                 Click("//button[contains(@class,'confirm')]");
                                for (int i = 0; i < 100; i++)
                                {
                                    if (!(driver.FindElement(By.XPath("//div[contains(@class, 'sweet-alert showSweetAlert visible')]/h2")).Text.Equals("License Warning")))
                                    {
                                        break;
                                    }
                                }
                                break;
                            }
                        }
                        break;

                    }
                }
                catch (Exception e)
                {
                    Console.Write(e);
                    Thread.Sleep(500);
                }
            }
        }
        public static void Delete()
        {
             CheckURl("/users");

             SendKeys("//input[contains(@class, \"form-control input-inline\")]", "Orjon's Automated Testuser");

             Table("//*[@id=\"tblUsers\"]", "//*[@id=\"tblUsers\"]/tbody/tr[1]/td[2]", "Orjon's Automated Testuser");
             Del();
        }
    }
}

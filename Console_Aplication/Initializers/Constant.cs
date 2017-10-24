using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OWASPZAPDotNetAPI;
using System;
using System.Threading;

namespace Console_Aplication
{
    public class Constant : Functions
    {
        public static String baseUrl = "http://prototypes.transputec.net/ccportal";
        //public static String baseUrl = "https://dev-portal.crises-control.com";
        //public static String baseUrl = "https://pp-portal.crises-control.com";
        public static String email, password, text = "";
        public static IWebDriver driver;

        public static string TextToSend = "Orjon's Automated Test";
        public static string UserNumber1 = "Orjon Cura";
        public static string UserNumber2 = "Denish Rai";
        //public static string TestLocation = "Denish Test Location";
        public static string TestLocation = "Denish's wembley stadium";
        public static string Dept_Groups = "Denish Test Dept/Groups";
        

        public static void Initializer()
        {
             CheckURl("/users/login");

             SendKeys("//input[contains(@id, 'Primary_Email')]", email);
             SendKeys("//input[contains(@id, 'password')]", password);

             Click("//input[contains(@class,\"btn btn-success btn-cons\")]");
        }

        public static void Cleanup()
        {
            driver.Quit();
        }
    }
}

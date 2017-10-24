
using OpenQA.Selenium;
using System;
using System.Threading;

namespace Console_Aplication
{
    public class Location : Constant
    {
        public static void Create() 
        {
            CheckURl("/location");

            Click("//a[contains(@class,\"btn btn-success dropdown-toggle\")]");
            Click("//a[contains(@href,\"" + baseUrl + "/location/create\")]");

            Click("//input[contains(@id,\"LocationName\")]");
            SendKeys("//input[contains(@id,\"LocationName\")]", "Orjon's Automated Test Location");

             SendKeys("//input[contains(@id,\"LocationAddress\")]", "19 Warley St, London E2 0PZ, UK");

            Click("//span[contains(@id,'address_map')]");
            while(Displayed("//div[contains(@class,'modal-dialog modal-md')]"))
            {
                if (Displayed("//*[contains(text(),'Select')]"))
                {
                    IWebElement element = driver.FindElement(By.XPath("//*[contains(text(),'Select')]"));
                    IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
                    executor.ExecuteScript("arguments[0].click();", element);
                    break;
                }
            }
            //SendKeys("//input[contains(@id,\"LocationLat\")]", "51.5265745");
            //SendKeys("//input[contains(@id,\"LocationLng\")]", "-0.0466531");

            SendKeys("//textarea[contains(@id,\"Description\")]", "test description");
            Click("//button[contains(@id,\"btn_submit\")]");

            }

          
        public static void Edit()
            {
                 CheckURl("/location");

                 SendKeys("//input[contains(@class, \"form-control input-inline\")]", "Orjon's Automated Test Location");
                 Table("//*[@id=\"tblLocation\"]", "//*[@id=\"tblLocation\"]/tbody/tr[1]/td[3]", "Orjon's Automated Test Location");
                 Click("//*[@id=\"tblLocation\"]/tbody/tr[1]/td[2]");

                 Click("//a[contains(@class,\"btn btn-sm btn-small btn-warning\")]");
                 SendKeys("//textarea[contains(@id, \"Description\")]", "new test description");

                 SendKeys("//input[contains(@aria-controls,\"NonMemberUsers\")]", "Orjon Cura");
                 Table("//*[@id=\"NonMemberUsers\"]", "//*[@id=\"NonMemberUsers\"]/tbody/tr[1]/td[2]", "Orjon Cura");
                 Click(".//td[4]/div/label");

                  Click(".//*[@id='btn_submit']");

            }

          
        public static void Delete()
            {

                 CheckURl("/location");

                 SendKeys(".//*[@id='tblLocation_filter']/label/input", "Orjon's Automated Test Location");
                 Table("//*[@id=\"tblLocation\"]", "//*[@id=\"tblLocation\"]/tbody/tr[1]/td[3]", "Orjon's Automated Test Location");

                 Click("//i[contains(@class,\"fa fa-plus-circle\")]");
                 Click("//span[contains(text(),'Automated Test Location')]");

                 Del();

        }

    }


}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Console_Aplication
{
    public class Group : Constant
    {
         
        public static void Create()
        {

             CheckURl("/security");

             Click("//a[contains(text(),'Add Group')]");

             SendKeys("//input[contains(@id,\"GroupName\")]", "Orjon's Automated Test Group");
             SendKeys("//textarea[contains(@id,\"Description\")]", "Automated Test Description");

             Click("//button[contains(@id,\"btn_submit\")]");
        }
         
        public static void Edit()
        {
             CheckURl("/security");

             SendKeys("//input[contains(@class, \"form-control input-inline\")]", "Orjon's Automated Test Group");
             Table("//*[@id=\"tblSecurity\"]", "//*[@id=\"tblSecurity\"]/tbody/tr[1]/td[1]", "Orjon's Automated Test Group");

             Click("//a[contains(@class,\"btn btn-sm btn-small btn-warning\")]");
             SendKeys("//textarea[contains(@id, \"Description\")]", "New automated test description");

             Click("//label[contains(text(),'Setup Locations')]");
             Click("//button[contains(@class,\"btn btn-success btn-cons submit\")]");

        }
         
        public static void Delete()
        {
            Thread.Sleep(2000);
             CheckURl("/security");

             SendKeys("//input[contains(@class, \"form-control input-inline\")]", "Orjon's Automated Test Group");
             Table("//*[@id=\"tblSecurity\"]", "//*[@id=\"tblSecurity\"]/tbody/tr[1]/td[1]", "Orjon's Automated Test Group");
             Del();

        }
    }
}

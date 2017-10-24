using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Console_Aplication
{
    public class Department : Constant
    {
        
        public static void Create()
        {

             CheckURl("/department");

             Click("//a[contains(@class,\"btn btn-success dropdown-toggle\")]");
             Click("//a[contains(@href,\"" + baseUrl + "/department/create\")]");

             SendKeys("//input[contains(@id,\"DepartmentName\")]", "Orjon's Test Department");

             Click("//button[contains(@class,\"btn btn-success btn-cons submit\")]");

        }
        
        public static void Edit()
        {
             CheckURl("/department");

             SendKeys("//input[contains(@class,\"form-control input-inline\")]", "Orjon's Test Department");
             Table("//*[@id=\"tblDepartment\"]", "//*[@id=\"tblDepartment\"]/tbody/tr[1]/td[3]", "Orjon's Test Department");
             Click("//*[@id=\"tblDepartment\"]/tbody/tr[1]/td[2]");

             Click("//a[contains(@class,\"btn btn-sm btn-small btn-warning\")]");

             SendKeys("//input[contains(@aria-controls,\"NonMemberUsers\")]", "Orjon Cura");
             Table("//*[@id=\"NonMemberUsers\"]", "//*[@id=\"NonMemberUsers\"]/tbody/tr[1]/td[2]", "Orjon Cura");

             Click(".//td[4]/div/label");

             Click(".//*[@id='btn_submit']");

        }
         
        public static void Delete()
        {
             CheckURl("/department");

             SendKeys(".//*[@id='tblDepartment_filter']/label/input", "Orjon Test Department");
             Table("//*[@id=\"tblDepartment\"]", "//*[@id=\"tblDepartment\"]/tbody/tr[1]/td[3]", "Orjon's Test Department");

            Del();
        }
    }
}

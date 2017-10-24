using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Console_Aplication
{
    public class ISOP_Wizard : Constant
    {
         
        public static void Create()
        {
             CheckURl("/sop/create/basic");

             Click("//input[contains(@placeholder,'Select sections')]");
             Click("//li[text() [contains(.,'Executive Summary')]]");

             Click("//span[contains(@id,\"select2-IncidentID-container\")]");
             Click("//li[text() [contains(.,'(TEST) Aircraft Damage')]]");

             SendKeys("//input[contains(@id, \"Author\")]", "Orjon");
             SendKeys("//input[contains(@id, \"SOPVersion\")]", "Version 1");

             Click("//input[contains(@id,\"ReviewDate\")]");
             Click("//*[@id=\"sop_create\"]/div[5]/div[1]/table/tbody/tr[5]/td[7]");

             Click("//span[contains(@id,\"select2-ReviewFrequency-container\")]");
             Click("//li[text() [contains(.,'Yearly')]]");

             SendKeys("//textarea[contains(@id, \"BriefDescription\")]", "Test ISOP");
             Click("//button[contains(@id,\"btn_submit\")]");

            //ClickCSS("a.cursorp.semi-bold.a.collapsed::after");

             Click("//button[contains(@id,\"btn_add_section\")]");
             SendKeys("//input[contains(@placeholder, \"Select owners for this section.\")]", "Orjon Cura" );
             Click("//li[contains(@class,'select2-results__option select2-results__option--highlighted')]");

            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[contains(@class,'k-content')]")));
             SendKeys("/html/body", "Orjon's Test Task");
            driver.SwitchTo().DefaultContent();

             Click("//button[contains(@id,\"btn_save_section\")]");
             Click("//button[contains(@class,\"confirm\")]");


             Click("//button[contains(@id,\"btn_submit\")]");
             Click("//button[contains(@id,\"btn_generate_sop_top\")]");

             Click("//button[contains(@id,\"add_sop_to_assets\")]");
        }
         
        public static void Delete()
        {
             CheckURl("/mediaasset");
            
             SendKeys("//input[contains(@type, 'search')]", "SOP-(TEST) Aircraft Damage");
             Table("//*[@id=\"tblAsset\"]", "//*[@id=\"tblAsset\"]/tbody/tr[1]/td[1]", "SOP-(TEST) Aircraft Damage");


             Del();
        }
    }
}

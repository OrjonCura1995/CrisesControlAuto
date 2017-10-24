using OpenQA.Selenium;
using System;
using System.Threading;

namespace Console_Aplication
{
    public class Asset : Constant 
    {
        
        public static void Create()
        {
             CheckURl("/mediaasset");

             Click("//a[contains(@class, 'pull-right btn btn-success')]");

             Click("//input[contains(@id, \"AssetTitle\")]");

             SendKeys("//input[contains(@id, \"AssetTitle\")]", "Orjon's Test Asset");

             Click(".//*[@role='combobox']");
             Click("//li[text() [contains(.,'Normal Asset')]]");
             Click(".//*[@id='select2-AssetType-container']");
             Click("//li[text() [contains(.,'Website')]]");

             SendKeys("//textarea[contains(@id, \"AssetDescription\")]", "Test description");
             SendKeys("//input[contains(@id, \"WebsiteURL\")]", "test.com");

             Click("//input[contains(@id, \"AssetTitle\")]");
             Click("//button[contains(@id, \"btn_submit\")]");

        }
        
        public static void Edit()
        {
             CheckURl("/mediaasset");

             SendKeys("//input[contains(@type, 'search')]", "Orjon's Test Asset");
             Table("//*[@id=\"tblAsset\"]", "//*[@id=\"tblAsset\"]/tbody/tr[1]/td[1]", "Orjon's Test Asset");
             Click("//*[@id=\"tblAsset\"]/tbody/tr[1]/td[1]");


             Click("//a[contains(@class,\"btn btn-sm btn-small btn-warning\")]");

             Click("//input[contains(@id, \"WebsiteURL\")]");

             SendKeys("//input[contains(@id, \"WebsiteURL\")]", "testtwo.com");

             Click("//button[contains(@class, \"btn btn-success btn-cons submit\")]");
            
        }
        
        public static void Delete()
        {
             CheckURl("/mediaasset");

             SendKeys("//input[contains(@type, 'search')]", "Orjon's Test Asset");
             Table("//*[@id=\"tblAsset\"]", "//*[@id=\"tblAsset\"]/tbody/tr[1]/td[1]", "Orjon's Test Asset");

             Del();

        }
    }
}

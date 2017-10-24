using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Console_Aplication
{
    public class Trigger : Constant
    {
        public static void Create()
        {
            
             CheckURl("/ping/newping");

             SendKeys("//input[contains(@placeholder, 'Location')]", UserNumber2 + Keys.Enter);

             SendKeys("//input[contains(@placeholder, 'Users')]", UserNumber2 + Keys.Enter);

             Click("//textarea[contains(@id, 'Message')]");
             SendKeys("//textarea[contains(@id, 'Message')]", "Orjon's Test Ping with Audio Attachmen");

             Click("//span[contains(text(),\"Select\")]");
             Click("//li[contains(text(),\"Low\")]");

             Click("//a[contains(@data-cmd, \"pingaudiomessage\")]");

            Loop = 50;
            while (Displayed("//div[contains(@class, 'modal-content')]"))
            {
                if (Displayed("//span[contains(@id, 'astZGwvMzgrVmR0ZldhNTlpR2ZpQS9YUT09' )]"))
                {
                    Click("//span[contains(@id, 'astZGwvMzgrVmR0ZldhNTlpR2ZpQS9YUT09' )]");
                }
            }
            Loop = 10000;

            Click("//button[contains(@id, 'btn_trigger')]");

             SendKeys("//input[contains(@id, 'SourceEmail')]", "test@test.com");
             SendKeys("//input[contains(@id, 'FailureEmail')]", "test@test.com");

             Click("//button[contains(@id, 'btn_submit')]");


        }

        public static void Edit()
        {
             CheckURl("/trigger");

             SendKeys("//input[contains(@class, 'form-control input-inline')]", "Test Ping with Audio Attachmen");
             Table("//*[@id=\"tblTrigger\"]", "//*[@id=\"tblTrigger\"]/tbody/tr[1]/td[2]", "Orjon's Test Ping with Audio Attachmen");

             Click("//a[contains(@class, \"btn btn-sm btn-small btn-warning\")]");

             SendKeys("//input[contains(@placeholder, 'Job Name')]", "Orjon's Test Ping with Audio Attachmen");

             Click("//button[contains(@id, 'btn_submit')]");
        }

        public static void Delete()
        {
             CheckURl("/trigger");

             SendKeys("//input[contains(@class, 'form-control input-inline')]", "Orjon's Test Ping with Audio Attachmen");
             Table("//*[@id=\"tblTrigger\"]", "//*[@id=\"tblTrigger\"]/tbody/tr[1]/td[2]", "Orjon's Test Ping with Audio Attachmen");

             Del();
        }
    }
}

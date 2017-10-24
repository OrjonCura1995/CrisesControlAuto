using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace Console_Aplication
{
    public class Incident : Constant 
    {  
        public static void Create()
        {
             CheckURl("/incident/incidentsetup");

             Click("//a[contains(@class,\"btn btn-success dropdown-toggle\")]");
             Click("//a[contains(@href,\"" + baseUrl + "/incident/create\")]");

             Click("//input[contains(@id,\"Name\")]");

             SendKeys("//textarea[contains(@id,\"Description\")]", TextToSend);

             SendKeys("//input[contains(@class,'select2-search')]", UserNumber1);
             Click("//li[contains(@class,'select2-results__option select2-results__option--highlighted')]");

             SendKeys("//input[contains(@class,'select2-search')]", UserNumber2);
             Click("//li[contains(@class,'select2-results__option select2-results__option--highlighted')]");

             SendKeys("//input[contains(@name,'Name')]", TextToSend );

             Click("//Span[contains(text(),'Incident Type')]");
             SendKeys(".//*[@id='incident_create']/span/span/span[1]/input", "Civil" + Keys.Enter);

             Click("//Span[contains(text(),'Severity')]");
             Click("//li[contains(text(),'4')]");

             Click("//Span[contains(text(),'holders')]");
             Click("//li[contains(text(),'1')]");

            IWebElement element =  driver.FindElement(By.XPath("//button[contains(@id,\"btn_submit\")]"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor) driver;
            executor.ExecuteScript("arguments[0].click();", element);
           
        }
         
        public static void Task()
        {
            CheckURl("/incident/incidentsetup");
            SendKeys("//input[contains(@type, 'search')]", TextToSend);
            Table("//*[@id=\"tbl_incident_setup\"]", "//*[@id=\"tbl_incident_setup\"]/tbody/tr[1]/td[2]", TextToSend);
            Click("//a[contains(@class,'btn btn-sm btn-small btn-warning')]");
            Click("//a[contains(@id,'incident_task_tab')]");

            Click("//button[contains(@id,'btn_config_task')]");


            Click("//button[contains(@id,'btn_add_task')]");

            SendKeys("//input[contains(@id,'TaskTitle')]", TextToSend);
            Click("//iframe[contains(@class,'k-content')]");

            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[contains(@class,'k-content')]")));
            SendKeys("/html/body", TextToSend);
            driver.SwitchTo().DefaultContent();

            SendKeys("//input[contains(@placeholder,'Select Action Users')]", UserNumber1 + Keys.Enter);
            SendKeys("//input[contains(@placeholder,'Select Action Groups')]", Dept_Groups + Keys.Enter);

            SendKeys("//input[contains(@placeholder,'Select Escalation Users')]", UserNumber1 + Keys.Enter);
            SendKeys("//input[contains(@placeholder,'Select Escalation Groups')]", Dept_Groups + Keys.Enter);

            Click("//button[contains(@id,'btn_save_task')]");

            //Add Second Task 

            Click("//button[contains(@id,'btn_add_task')]");

            SendKeys("//input[contains(@id,'TaskTitle')]", "Orjon's Test Task Number 2");
            Click("//iframe[contains(@class,'k-content')]");

            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[contains(@class,'k-content')]")));
            SendKeys("/html/body", TextToSend);
            driver.SwitchTo().DefaultContent();

            SendKeys("//input[contains(@placeholder,'Select Action Users')]", UserNumber1 + Keys.Enter);
            SendKeys("//input[contains(@placeholder,'Select Action Groups')]", Dept_Groups + Keys.Enter);

            SendKeys("//input[contains(@placeholder,'Select Escalation Users')]", UserNumber1 + Keys.Enter);
            SendKeys("//input[contains(@placeholder,'Select Escalation Groups')]", Dept_Groups + Keys.Enter);

            Click("//button[contains(@id,'btn_save_task')]");

            Click("//button[contains(@id,'task0')]");
            SendKeys("//input[contains(@id,'TaskTitle')]", "Orjon's Test Edit Task");
            Click("//button[contains(@id,'btn_save_task')]");


        }

        public static void Launch()
        {
             CheckURl("/incident/newincident");

             SendKeys("//input[contains(@type, 'search')]", TextToSend );
             Table("//*[@id=\"tbl_incident_list\"]", "//*[@id=\"tbl_incident_list\"]/tbody/tr[1]/td[2]", TextToSend);

             Click("//a[contains(@class,'btn activateIncident btn-small btn-success')]");

             Click("//span[contains(@title,'Select Impacted Location')]");
             SendKeys("//*[@id='incident_initiate']/span/span/span[1]/input", TestLocation + Keys.Enter);

             Click("//input[contains(@placeholder, 'Select Location(s) to notify')]");
             SendKeys("//input[contains(@placeholder, 'Select Location(s) to notify')]", TestLocation + Keys.Enter);
             Click(".//*[@id='btn_activate_incident']");

             SendKeys("//input[contains(@placeholder, 'Password')]", password);

             Click("//*[@id='InciPwdConfirm']");
        }

        public static void Task2()
        {
            CheckURl("/incidenttask/mytask");
            ClickCSS("div > div.task-body.scrolldiv > table.table.table-condensed.inc.cursorp > tbody > tr > td.indes > div");
            Click("//*[contains(text(), 'Accept')]");
            Click("//*[contains(text(), 'OK')]");

            //Send Update
            ClickCSS("#incidenttask_task > div.sweet-alert.showSweetAlert.visible > div.sa-button-container > div > button");

            Click("//button[contains(@id,'btn_update_task0')]");
            Click("//input[contains(@placeholder,'Select groups to notify.')]");
            ClickCSS(".select2-results__option--highlighted");

            SendKeys("//textarea[contains(@id,'TaskActionReason')]", "Task Test");
            Click("//button[contains(@id,'btn_send_update')]");

            //Task Reallocation
            ClickCSS("#incidenttask_task > div.sweet-alert.showSweetAlert.visible > div.sa-button-container > div > button");
            Click("//button[contains(@id,'btn_allocate_task0')]");
            ClickCSS("#incidenttask_task > div.sweet-alert.showSweetAlert.visible > div.sa-button-container > div > button");
            SendKeys("//textarea[contains(@id,'TaskActionReason')]", TextToSend);
            Click("//button[contains(@id,'btn_confirm_task_action')]");

            //Task Delegation
            ClickCSS("#incidenttask_task > div.sweet-alert.showSweetAlert.visible > div.sa-button-container > div > button");
            Click("//div[@class='col-lg-3']//button[.='Delegate']");
            ClickCSS("#incidenttask_task > div.sweet-alert.showSweetAlert.visible > div.sa-button-container > div > button");
        
            Click("//span[contains(@class,'select2-selection__placeholder')]");
            SendKeys("//input[contains(@class,'select2-search__field')]", UserNumber2);
            ClickCSS(".select2-results__option--highlighted");
            SendKeys("//textarea[contains(@id,'TaskActionReason')]", TextToSend);
            Click("//div[@class='modal-footer']//button[.='Submit']");

            //Click("//button[contains(@id,'btn_reject_task0')]");
        }

        public static void IncidentDetails()
        {
            //View Report
             CheckURl("/incident/activeincidents");

             SendKeys("//input[contains(@class, \"form-control input-inline\")]", TextToSend );
             Table("//*[@id=\"launchedIncidentTable\"]", "//*[@id=\"launchedIncidentTable\"]/tbody/tr[1]/td[2]", TextToSend );

             Click("//button[contains(@class,\"btn btn-success btn-sm btn-small dropdown-toggle\")]");
             Click("//*[contains(text(),'View Report')]");

            //Incident Audit
             CheckURl("/incident/activeincidents");

             SendKeys("//input[contains(@class, \"form-control input-inline\")]", TextToSend );
             Table("//*[@id=\"launchedIncidentTable\"]", "//*[@id=\"launchedIncidentTable\"]/tbody/tr[1]/td[2]", TextToSend );

             Click("//button[contains(@class,\"btn btn-success btn-sm btn-small dropdown-toggle\")]");
             Click("//*[contains(text(),'Incident Audit')]");

            //Incident Timeline
             CheckURl("/incident/activeincidents");

             SendKeys("//input[contains(@class, \"form-control input-inline\")]", TextToSend );
             Table("//*[@id=\"launchedIncidentTable\"]", "//*[@id=\"launchedIncidentTable\"]/tbody/tr[1]/td[2]", TextToSend );

             Click("//button[contains(@class,\"btn btn-success btn-sm btn-small dropdown-toggle\")]");
             Click("//*[contains(text(),'Incident Timeline')]");

            //Acknowledgements
             CheckURl("/incident/activeincidents");

             SendKeys("//input[contains(@class, \"form-control input-inline\")]", TextToSend );
             Table("//*[@id=\"launchedIncidentTable\"]", "//*[@id=\"launchedIncidentTable\"]/tbody/tr[1]/td[2]", TextToSend );

             Click("//button[contains(@class,\"btn btn-success btn-sm btn-small dropdown-toggle\")]");
             Click("//*[contains(text(),'Acknowledgements')]");

            //Conference Call
             CheckURl("/incident/activeincidents");

             SendKeys("//input[contains(@class, \"form-control input-inline\")]", TextToSend );
             Table("//*[@id=\"launchedIncidentTable\"]", "//*[@id=\"launchedIncidentTable\"]/tbody/tr[1]/td[2]", TextToSend );

             Click("//button[contains(@class,\"btn btn-success btn-sm btn-small dropdown-toggle\")]");
             Click("//*[contains(text(),'Conference Call')]");

            //Send Update
             CheckURl("/incident/activeincidents");

             SendKeys("//input[contains(@class, \"form-control input-inline\")]", TextToSend );
             Table("//*[@id=\"launchedIncidentTable\"]", "//*[@id=\"launchedIncidentTable\"]/tbody/tr[1]/td[2]", TextToSend );

             Click("//button[contains(@class,\"btn btn-success btn-sm btn-small dropdown-toggle\")]");
             Click("//*[contains(text(),'Send Update')]");

             SendKeys("//textarea[contains(@id,\"InciMsg\")]", TextToSend);
             Click("//span[contains(@id,\"select2-Priority-container\")]");
             Click("//li[contains(text(),'Low')]");

             Click("//input[contains(@placeholder, 'Select Location(s) to notify')]");
             SendKeys("//input[contains(@placeholder, 'Select Location(s) to notify')]", TextToSend  + Keys.Enter);
             Click("//button[contains(@id,\"btn_send_notification\")]");

        }
         
        public static void Deactivate()
        {
             CheckURl("/incident/activeincidents");

             SendKeys("//input[contains(@class, \"form-control input-inline\")]", TextToSend );
             Table("//*[@id=\"launchedIncidentTable\"]", "//*[@id=\"launchedIncidentTable\"]/tbody/tr[1]/td[2]", TextToSend );


             Click("//button[contains(@class,\"btn btn-success btn-sm btn-small dropdown-toggle\")]");
             Click("//a[contains(@class,\"dropdown-item inciDeact\")]");

             SendKeys("//textarea[contains(@id,\"AuthenReason\")]", TextToSend);
             SendKeys("//input[contains(@id,\"AuthenPwd\")]", password);

             Click("//button[contains(@id,\"InciCancel\")]");
        }

        public static void Edit()
        {
            CheckURl("/incident/incidentsetup");

            SendKeys("//input[contains(@type,\"search\")]", TextToSend );
            Table("//*[@id=\"tbl_incident_setup\"]", "//*[@id=\"tbl_incident_setup\"]/tbody/tr[1]/td[2]", TextToSend );

            Click("//a[contains(@class,\"btn btn-sm btn-small btn-warning\")]");

            //Add message

            Click("//a[contains(@id, 'addInciAction')]");

            SendKeys("//textarea[contains(@id, \"ActionDescription\")]", TextToSend);
            Click("//button[contains(@id, 'btnSubmitAct')]");
            Click("//button[contains(@class, 'confirm')]");

            //Add Media Asset

            Click("//a[contains(@class,'btn btn-success btn-cons pull-left')]");

            Loop = 50;
            while (!Displayed("//input[contains(@id, \"AssetTitle\")]"))
            {
                Click("//button[contains(@id,'addAssetAjax')]");
            }
            Loop = 10000;

            Click("//input[contains(@id, \"AssetTitle\")]");

            SendKeys("//input[contains(@id, \"AssetTitle\")]", TextToSend);


            Click(".//*[@id='select2-AssetType-container']");
            Click("//li[text() [contains(.,'Website')]]");

            SendKeys("//textarea[contains(@id, \"AssetDescription\")]", TextToSend);
            SendKeys("//input[contains(@id, \"WebsiteURL\")]", "test.com");

            Click("//button[contains(@id, 'btnSubmitAst')]");
        }


        public static void Delete()
        {
             CheckURl("/incident/incidentsetup");

             SendKeys("//input[contains(@type,\"search\")]", TextToSend );
             Table("//*[@id=\"tbl_incident_setup\"]", "//*[@id=\"tbl_incident_setup\"]/tbody/tr[1]/td[2]", TextToSend );

             Del();

        }

    }
}

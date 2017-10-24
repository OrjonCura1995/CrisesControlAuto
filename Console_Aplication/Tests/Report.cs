using OpenQA.Selenium;

namespace Console_Aplication
{
    public class Report : Constant
    {
        public static void report()
        {
            //Ping Report 
            CheckURl("/reports/pingreport");
            Click("//label[contains(text(),'Custom Period')]");

            ClickCSS("#grp_date_set > .form-group:nth-of-type(2) > .input-group.date.success.withpast.no-padding.stdate > .input-group-addon.success");
            ClickCSS(".datepicker-days > table.table-condensed > thead > tr:nth-of-type(2) > th.datepicker-switch");
            ClickCSS(".datepicker-months > table.table-condensed > thead > tr:nth-of-type(2) > th.datepicker-switch");
            ClickCSS("table.table-condensed > tbody > tr > td > .year:nth-of-type(2)");

            ClickCSS("table.table-condensed > tbody > tr > td > .month:nth-of-type(1)");
            ClickCSS("table.table-condensed > tbody > tr:nth-of-type(2) > td.day:nth-of-type(1)");
            ClickCSS("#grpbtnSubmit");

            ClickCSS("g.highcharts-series > path:nth-of-type(4)");

             CheckURl("/reports/incidentreport");
             Click("//label[contains(text(),'Last Month')]");

             CheckURl("/reports/userreport");
             Click("//label[contains(text(),'Last Month')]");

             CheckURl("/reports/pingreport");
             Click("//label[contains(text(),'Last Month')]");

             CheckURl("/reports/performancereport");
             Click("//label[contains(text(),'Last Month')]");

             CheckURl("/reports/devicereport");

             CheckURl("/reports/dataexport");
             Click("//*[@id=\"tblDataExport\"]/tbody/tr[1]/td[2]");
             Click("//*[@id=\"tblDataExport\"]/tbody/tr[2]/td[2]");
             Click("//*[@id=\"tblDataExport\"]/tbody/tr[3]/td[2]");
             Click("//*[@id=\"tblDataExport\"]/tbody/tr[4]/td[2]");

             CheckURl("/reports/dataaudit");
             Click("//*[@id=\"select2-module-container\"]");
             Click("//option[contains(text(),'Locations')]");


             Click("//*[@id=\"select2-moduleitem-container\"]");
             Click("//option[contains(text(),'Locations')]");
             SendKeys("//input[contains(@class, 'select2-search__field')]", TestLocation + Keys.Enter);
             Click("//label[contains(text(),'Last Month')]");
        }
    }
}

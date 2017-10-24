using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Aplication
{
    class Company_Setup : Constant
    {
        public static void Modifiy()
        {
            CheckURl("/company");
            
            SendKeys("//input[contains(@id,'CompanyName')]", "Transputec");
            SendKeys("//input[contains(@id,'Address1')]", "Transputec London Bridge");
            SendKeys("//input[contains(@id,'CompanyCity')]", "London Bridge");

            Click("//button[contains(@id,'btn_company_submit')]");
        }

        public static void Modifiy2()
        {
            CheckURl("/company");

            SendKeys("//input[contains(@id,'CompanyName')]", "Transputec limited");
            SendKeys("//input[contains(@id,'Address1')]", "Transputec House");
            SendKeys("//input[contains(@id,'CompanyCity')]", "Wembley");

            Click("//button[contains(@id,'btn_company_submit')]");
        }
    }
}

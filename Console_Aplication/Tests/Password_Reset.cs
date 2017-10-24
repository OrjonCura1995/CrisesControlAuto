using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Aplication
{
    public class Password : Constant
    {
        public static void Reset()
        {
            
             CheckURl("/users/login");

             Click("//*[@id='btn_forgot_pass']");

             SendKeys("//*[@id='Email']", email);

             Click("//*[@id='btn_continue']");
             Click("//*[@id='btn_continue']");
         }
    }
}

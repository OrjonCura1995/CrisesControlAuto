using OpenQA.Selenium.Chrome;
using System;

namespace Console_Aplication
{ 
    class Controller : Constant
    {
        static void Main(string[] args)
        {
            driver = new ChromeDriver();
            text = "";

            Feedback(Password.Reset, "Password Reset");

            Console.WriteLine("Please Enter Your Email");
            email = Console.ReadLine();
            Console.WriteLine("Please Enter Your Password");
            password = Console.ReadLine();


            Initializer();

            Report.report();

            Feedback(Incident.Create, "Create Incident");
            Incident.Task();
            Feedback(Incident.Launch, "Launch Incident");
            Incident.Task2();
            Incident.IncidentDetails();
            Feedback(Incident.Deactivate, "Deactivate Incident");
            Feedback(Incident.Edit, "Edit Incident");
            Feedback(Incident.Delete, "Delete Incident");

            Feedback(Location.Create, "Create Location");
            Feedback(Location.Edit, "Edit Location");
            Feedback(Location.Delete, "Delete Location");

            Feedback(Group.Create, "Create Group");
            Feedback(Group.Edit, "Edit Group");
            Feedback(Group.Delete, "Delete Group");

            Feedback(Department.Create, "Create Department");
            Feedback(Department.Edit, "Edit Department");
            Feedback(Department.Delete, "Delete Department");

            Feedback(Asset.Create, "Create Asset");
            Feedback(Asset.Edit, "Edit Asset");
            Feedback(Asset.Delete, "Delete Asset");

            Feedback(User.Create, "Create User");
            Feedback(User.Edit, "Edit User");
            Feedback(User.Delete, "Delete User");

            Feedback(ISOP_Wizard.Create, "Create ISOP Wizard");
            Feedback(ISOP_Wizard.Delete, "Delete ISOP Wizard");

            Feedback(Scheduler.Schedule, "Schedule Ping");
            Feedback(Scheduler.Edit, "Edit Scheduled Ping");
            Feedback(Scheduler.Delete, "Delete Scheduled Ping");

            Feedback(Trigger.Create, "Trigger Ping");
            Feedback(Trigger.Edit, "trigger Triggered Ping");
            Feedback(Trigger.Delete, "Delete Triggered Ping");

            Feedback(Company_Setup.Modifiy, "Company Setup");
            Feedback(Company_Setup.Modifiy2, "Company Setup");
            Feedback(Ping.Create, "Create Ping");
            Feedback(Ping.Acknowledge, "Acknowledge Ping");

            txt(text);

            Cleanup();
        }
    } 
}

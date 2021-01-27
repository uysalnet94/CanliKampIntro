using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //    PersonalFinanceCredit personalFinanceCredit = new PersonalFinanceCredit();
            //    personalFinanceCredit.Calculate();

            //    VehicleCredit vehicleCredit = new VehicleCredit();
            //    vehicleCredit.Calculate();

            //    MortgageCreditManager mortgageCreditManager = new MortgageCreditManager();
            //    mortgageCreditManager.Calculate();
            /********************************************/
            ICreditManager personalFinanceCredit = new PersonalFinanceCredit();
            ICreditManager vehicleCredit = new VehicleCredit();
            ICreditManager mortgageCreditManager = new MortgageCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.DoApplication(new EsnafCreditManager(), new SmsLoggerService());

            List<ICreditManager> credits = new List<ICreditManager>() { personalFinanceCredit, mortgageCreditManager, vehicleCredit };
            //applicationManager.DoCreditPreInformation(credits);
        }
    }
}

namespace Payroll_Management.Finance.Data
{
    public class FinanceMockDataService
    {
        public static List<Models.Finance> Payroll = new List<Models.Finance>()
        {
            new Models.Finance { Id = 1, Pay_Period = "2023 - APR_MAY", Gross_Pay = 137520.50, Deductions = 7512.32, Payment_Method = "Direct Deposit", Payroll_Taxes = 682.41, Payroll_Period = "4th week of the month", Department =  "IT"},
            new Models.Finance { Id = 2, Pay_Period = "2023 - APR_MAY", Gross_Pay = 73505.50, Deductions = 5412.32, Payment_Method = "Direct Deposit", Payroll_Taxes = 682.41, Payroll_Period = "4th week of the month", Department =  "HR"},
            new Models.Finance { Id = 3, Pay_Period = "2023 - APR_MAY", Gross_Pay = 67500.50, Deductions = 3211.19, Payment_Method = "Check", Payroll_Taxes = 682.41, Payroll_Period = "2nd week of the month", Department =  "Audit"},
            new Models.Finance { Id = 4, Pay_Period = "2023 - APR_MAY", Gross_Pay = 69547.50, Deductions = 1565.47, Payment_Method = "Check", Payroll_Taxes = 682.41, Payroll_Period = "2nd week of the month", Department =  "Finance"},
            new Models.Finance { Id = 5, Pay_Period = "2023 - APR_MAY", Gross_Pay = 49518.50, Deductions = 1633.63, Payment_Method = "Direct Deposit", Payroll_Taxes = 682.41, Payroll_Period = "4th week of the month", Department =  "IT"},
        };
    }
}

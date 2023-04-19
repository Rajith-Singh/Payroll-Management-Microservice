using Payroll_Management.Finance.Data;
using Payroll_Management.Finance.Models;


namespace Payroll_Management.Finance.Services
{
    public class FinanceService:IFinanceService
    {
        public List<Models.Finance> GetPayroll()
        {
            return FinanceMockDataService.Payroll;
        }

        public Models.Finance? GetPayroll(int id)
        {
            return FinanceMockDataService.Payroll.FirstOrDefault(x => x.Id == id);
        }

        public Models.Finance? AddPayroll(Models.Finance payroll)
        {
            FinanceMockDataService.Payroll.Add(payroll);
            return payroll;
        }

        public Models.Finance? UpdatePayroll(Models.Finance payroll)
        {
            Models.Finance selectedPayroll = FinanceMockDataService.Payroll.FirstOrDefault(x => x.Id == payroll.Id);
            if (selectedPayroll != null)
            {
                selectedPayroll.Pay_Period = payroll.Pay_Period;
                selectedPayroll.Gross_Pay = payroll.Gross_Pay;
                selectedPayroll.Deductions = payroll.Deductions;
                selectedPayroll.Payment_Method = payroll.Payment_Method;
                selectedPayroll.Payroll_Taxes = payroll.Payroll_Taxes;
                selectedPayroll.Payroll_Period = payroll.Payroll_Period;
                selectedPayroll.Department = payroll.Department;
                return selectedPayroll;
            }

            return selectedPayroll;
        }

        public bool? DeletePayroll(int id)
        {
            Models.Finance selectedPayroll = FinanceMockDataService.Payroll.FirstOrDefault(x => x.Id == id);
            if (selectedPayroll != null)
            {
                FinanceMockDataService.Payroll.Remove(selectedPayroll);
                return true;
            }
            return false;
        }
    }
}

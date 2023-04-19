namespace Payroll_Management.Finance.Services
{
    public interface IFinanceService
    {
        List<Models.Finance> GetPayroll();
        Models.Finance? GetPayroll(int id);
        Models.Finance? AddPayroll(Models.Finance payroll);
        Models.Finance? UpdatePayroll(Models.Finance payroll);
        bool? DeletePayroll(int id);
    }
}

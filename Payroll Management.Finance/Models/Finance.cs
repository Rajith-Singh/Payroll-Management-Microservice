namespace Payroll_Management.Finance.Models
{
    public class Finance
    {
        public int Id { get; set; }
        public string? Pay_Period { get; set; }
        public double Gross_Pay { get; set; }
        public double Deductions { get; set; }
        public string? Payment_Method { get; set; }
        public double Payroll_Taxes { get; set; }
        public string? Payroll_Period { get; set; }
        public string? Department { get; set; }

    }
}

using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using Payroll_Management.Finance.Data;
using Payroll_Management.Finance.Services;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Payroll_Management.Finance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FinanceController : ControllerBase
    {
        private readonly IFinanceService _payrollService;

        public FinanceController(IFinanceService payrollService)
        {
            _payrollService = payrollService ?? throw new ArgumentNullException(nameof(payrollService));
        }

        /// <summary>
        /// Get all payroll details
        /// </summary>
        /// <returns>return the list of payroll</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_payrollService.GetPayroll());
        }

        /// <summary>
        /// Get Payroll record by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return the payroll record with the passed ID</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _payrollService.GetPayroll(id) != null ? Ok(_payrollService.GetPayroll(id)) : NoContent();
        }

        /// <summary>
        /// Add payroll record
        /// </summary>
        /// <param name="payroll"></param>
        /// <returns>Return the added student</returns>
        [HttpPost]
        public IActionResult Post([FromBody] Models.Finance payroll)
        {
            return Ok(_payrollService.AddPayroll(payroll));
        }

        /// <summary>
        /// Update the payroll record
        /// </summary>
        /// <param name="payroll"></param>
        /// <returns>Return the updated Payroll record</returns>
        [HttpPut]
        public IActionResult Put([FromBody] Models.Finance payroll)
        {
            return Ok(_payrollService.UpdatePayroll(payroll));
        }

        /// <summary>
        /// Delete the payroll record with the passed ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _payrollService.DeletePayroll(id);

            return result.HasValue & result == true ? Ok($"payroll with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete the payroll with ID:{id}.");
        }
    }
}
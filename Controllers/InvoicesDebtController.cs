using Microsoft.AspNetCore.Mvc;
using CompositeCRM.Data;
using CompositeCRM.Models;
using System.Threading.Tasks;

namespace CompositeCRM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoicesDebtController : ControllerBase
    {

        private readonly IDataInvoicesDebt dataInvoicesDebt;
        public InvoicesDebtController(IDataInvoicesDebt invoicesDebt)
        {
            dataInvoicesDebt = invoicesDebt;
        }

        [HttpGet]
        public async Task<JsonResult> GetAllInvoicesAsync()
        {
           return await dataInvoicesDebt.GetAllAnvoicesDebtAsync();
        }

        [HttpGet("{Id}")]
        public async Task<JsonResult> GetOneInvoiceAsync(int Id)
        {
            return await  dataInvoicesDebt.GetInvoicesDebtAsync(Id);
        }

        [HttpPost]

        public async Task<JsonResult> EditInvoicesDebtAsync(InvoicesDebt invoicesDebt)
        {
            return await dataInvoicesDebt.EditInvoicesDebtAsync(invoicesDebt);
        }

        [HttpPut]
        public async Task<JsonResult> ChangeInvoicesDebtAsync(InvoicesDebt invoicesDebt)
        {
            return await dataInvoicesDebt.ChangeInvoicesDebtAsync(invoicesDebt);
        }

        [HttpDelete("{id}")]
        public Task<JsonResult> DeleteInvoicesDebtAsync(int Id)
        {
            return dataInvoicesDebt.DeleteInvoicesDebtAsync(Id);
        }
    }

}

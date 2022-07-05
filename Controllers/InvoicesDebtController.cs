using Microsoft.AspNetCore.Mvc;
using CompositeCRM.Data;
using CompositeCRM.Models;

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
        public JsonResult GetAllInvoices()
        {
           return dataInvoicesDebt.GetAllAnvoicesDebt();
        }

        [HttpGet("{Id}")]
        public JsonResult GetOneInvoice(int Id)
        {
            return  dataInvoicesDebt.GetInvoicesDebt(Id);
        }

        [HttpPost]

        public JsonResult EditInvoicesDebt(InvoicesDebt invoicesDebt)
        {
            return dataInvoicesDebt.EditInvoicesDebt(invoicesDebt);
        }

        [HttpPut]
        public JsonResult ChangeInvoicesDebt(InvoicesDebt invoicesDebt)
        {
            return dataInvoicesDebt.ChangeInvoicesDebt(invoicesDebt);
        }

        [HttpDelete("{id}")]
        public JsonResult DeleteInvoicesDebt(int Id)
        {
            return dataInvoicesDebt.DeleteInvoicesDebt(Id);
        }
    }

}

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

        [HttpPost]

        public JsonResult EditInvoicesDebt(InvoicesDebt invoicesDebt)
        {
            return dataInvoicesDebt.EditInvoicesDebt(invoicesDebt);
        }
    }

}

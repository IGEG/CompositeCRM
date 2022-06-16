using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using CompositeCRM.Data;

namespace CompositeCRM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoicesDebtController : ControllerBase
    {
        private readonly IConfiguration configuration;
        IDataInvoicesDebt dataInvoicesDebt;
        public InvoicesDebtController(IConfiguration conf, IDataInvoicesDebt invoicesDebt)
        {
            configuration = conf;
            dataInvoicesDebt = invoicesDebt;
        }

    }

    [HttpGet]
    void GetInvoices(int Id)
    { 
    
    }
}

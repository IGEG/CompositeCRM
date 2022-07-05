using CompositeCRM.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CompositeCRM.Data
    
{
    public interface IDataInvoicesDebt
    {
        JsonResult GetInvoicesDebt(int Id);

        JsonResult GetAllAnvoicesDebt();

        JsonResult EditInvoicesDebt(InvoicesDebt invoicesDebt);

        JsonResult ChangeInvoicesDebt(InvoicesDebt invoicesDebt);

        JsonResult DeleteInvoicesDebt(int Id);

    }
}

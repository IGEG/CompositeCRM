using CompositeCRM.Models;
using Microsoft.AspNetCore.Mvc;

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

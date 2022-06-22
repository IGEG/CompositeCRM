using CompositeCRM.Models;
using Microsoft.AspNetCore.Mvc;

namespace CompositeCRM.Data
    
{
    public interface IDataInvoicesDebt
    {
        JsonResult GetInvoicesDebt(int Id);

        JsonResult GetAllAnvoicesDebt();

        JsonResult EditInvoicesDebt(InvoicesDebt invoicesDebt);

        void DeleteInvoicesDebt(int Id);

    }
}

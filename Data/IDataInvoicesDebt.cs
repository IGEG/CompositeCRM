using CompositeCRM.Models;
using Microsoft.AspNetCore.Mvc;

namespace CompositeCRM.Data
    
{
    public interface IDataInvoicesDebt
    {
        JsonResult GetInvoicesDebt(int Id);

        void GetAllAnvoicesDebt();

        void DeleteInvoicesDebt(int Id);

    }
}

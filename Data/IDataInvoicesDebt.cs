using CompositeCRM.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CompositeCRM.Data
    
{
    public interface IDataInvoicesDebt
    {
        Task<JsonResult> GetInvoicesDebtAsync(int Id);

        Task<JsonResult> GetAllAnvoicesDebtAsync();

        Task<JsonResult> EditInvoicesDebtAsync(InvoicesDebt invoicesDebt);

        Task<JsonResult> ChangeInvoicesDebtAsync(InvoicesDebt invoicesDebt);

        Task<JsonResult> DeleteInvoicesDebtAsync(int Id);

    }
}

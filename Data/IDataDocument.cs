using CompositeCRM.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CompositeCRM.Data
{
    public interface IDataDocument
    {
          Task<JsonResult> GetAllDocumentsAsync();
          Task<JsonResult> GetDocumentAsync(int Id);
          Task<JsonResult> EditDocumentAsync(Document document);
          Task<JsonResult> ChangeDocumentAsync(Document document);
          Task<JsonResult> DeleteDocumentAsync(int Id);

    }
}

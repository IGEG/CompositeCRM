using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using CompositeCRM.Data;
using CompositeCRM.Models;

namespace CompositeCRM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        private readonly IDataDocument document;
        public DocumentController(IDataDocument doc)
        {
            document = doc;
        }
        [HttpGet("{id}")]
        public async Task<JsonResult> GetDocumentAsync(int Id)
        {
            return await document.GetDocumentAsync(Id);

        }
        [HttpGet]
        public async Task<JsonResult> GetAllDocumentsAsync()
        {
            return await document.GetAllDocumentsAsync();
        }


        [HttpPost]
        public async Task<JsonResult> EditDocumentAsync(Document doc)
        {
            return await document.EditDocumentAsync(doc);
        }

       
        [HttpPut]
        public async Task<JsonResult> ChangeDocumentAsync(Document doc)
        {
            return await document.ChangeDocumentAsync(doc);
        }

        [HttpDelete("{id}")]
        public async Task<JsonResult> DeleteDocumentAsync(int id)
        {
            return await document.DeleteDocumentAsync(id);
        }
    }
}

using CompositeCRM.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CompositeCRM.Data
{
    public class DataDocument : IDataDocument
    {
        private readonly IConfiguration Configuration;

        public DataDocument(IConfiguration conf)
        {
            Configuration = conf;
        }
        public async Task<JsonResult> GetAllDocumentsAsync()
        {
            string query = @"select Id,Clients,TypeDoc,DateOfAdded,Employer from dbo.Documents";
            string connect = Configuration.GetConnectionString("InvoicesDebt");
            DataTable dataTable = new DataTable();
            SqlDataReader reader;
            using (SqlConnection connection = new SqlConnection(connect))
            {
               connection.Open();
            using (SqlCommand command = new SqlCommand(query, connection))
                {
                    reader = await command.ExecuteReaderAsync();
                    dataTable.Load(reader);
                    reader.Close();
                }
                connection.Close();
            }
            return new JsonResult(dataTable);
        }

        public async Task<JsonResult> DeleteDocumentAsync(int Id)
        {
            string query = @"delete from Documents where Id = " + Id + @"";
            string connect = Configuration.GetConnectionString("InvoicesDebt");
            SqlDataReader reader;
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    reader = await command.ExecuteReaderAsync();
                    dataTable.Load(reader);
                    reader.Close();
                
                }
                connection.Close();
            }
            return new JsonResult("Данные успешно удалены");
        }

            public async Task<JsonResult> EditDocumentAsync(Document document)
        {
            string query = @"insert into Documents values (N'" + document.Clients + @"',N'" + document.TypeDoc + @"','" + document.DateOfAdded +
                 @"',N'" + document.Employer + @"')";


            string connect = Configuration.GetConnectionString("InvoicesDebt");

            DataTable dataTable = new DataTable();

            SqlDataReader reader;

            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    reader = await command.ExecuteReaderAsync();
                    dataTable.Load(reader);
                    reader.Close();

                }
                connection.Close();
            }

            return new JsonResult("Данные добавлены!");
        }

        public async Task<JsonResult> ChangeDocumentAsync(Document document)
        {

            string query = @"update Documents set
       Clients = N'" + document.Clients +
      @"',TypeDoc =N'" + document.TypeDoc  +
      @"',DateOfAdded = '" + document.DateOfAdded +
      @"',Employer = N'" + document.Employer + @"'";


            string connect = Configuration.GetConnectionString("InvoicesDebt");

            DataTable dataTable = new DataTable();

            SqlDataReader reader;

            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    reader = await command.ExecuteReaderAsync();
                    dataTable.Load(reader);
                    reader.Close();

                }
                connection.Close();
            }

            return new JsonResult("Данные изменены!");
        }

        public async Task<JsonResult> GetDocumentAsync(int Id)
        {
            string query = @"select Id,Clients,TypeDoc,DateOfAdded,Employer from dbo.Documents where Id="+Id+@"";
            string connect = Configuration.GetConnectionString("InvoicesDebt");
            SqlDataReader reader;
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connect))
            {  connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    reader = await command.ExecuteReaderAsync();
                    dataTable.Load(reader);
                    reader.Close();
                }
                connection.Close();
            }
            return new JsonResult(dataTable);
        }
    }
}

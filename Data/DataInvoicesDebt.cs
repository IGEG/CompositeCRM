using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using CompositeCRM.Models;

namespace CompositeCRM.Data
{
    public class DataInvoicesDebt : IDataInvoicesDebt
    {
        private readonly IConfiguration configuration;
        public DataInvoicesDebt(IConfiguration conf)
        {
            configuration = conf;
        }
        public void DeleteInvoicesDebt(int Id)
        {
            throw new System.NotImplementedException();
        }

        public JsonResult EditInvoicesDebt(InvoicesDebt invoicesDebt)
        {
            string query = @"insert into InvoicesDebts values (N'"+invoicesDebt.DepartmentNameDebt + @"','"+ invoicesDebt.DateInvoicesDebt + @"'," + invoicesDebt.InvoiceNumberDebt +
                @",'" + invoicesDebt.ClientNameDebt + @"'," + invoicesDebt.InvoiceAmountDebt + @",N'" + invoicesDebt.EmployeeFullNameDebt + @"'," + invoicesDebt.INNClientDebt +
                @",'" + invoicesDebt.InvoiseStatusDebt + @"')";
              

            string connectionString = configuration.GetConnectionString("InvoicesDebt");

            DataTable dataTable = new DataTable();

            SqlDataReader reader;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    reader = command.ExecuteReader();
                    dataTable.Load(reader);
                    reader.Close();

                }
                connection.Close();
            }

            return new JsonResult("Данные добавлены!");
        }

        public JsonResult GetAllAnvoicesDebt()
        {
            string query = @"select DepartmentNameDebt, DateInvoicesDebt, InvoiceNumberDebt, ClientNameDebt," +
                "InvoiceAmountDebt, EmployeeFullNameDebt, INNClientDebt, InvoiseStatusDebt from dbo.InvoicesDebts";

            string connectionString = configuration.GetConnectionString("InvoicesDebt");

            DataTable dataTable = new DataTable();

            SqlDataReader reader;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    reader = command.ExecuteReader();
                    dataTable.Load(reader);
                    reader.Close();

                }
                connection.Close();
            }

            return new JsonResult(dataTable);
        }

        public JsonResult GetInvoicesDebt(int Id)
        {
            string query = @"select DepartmentNameDebt, DateInvoicesDebt, InvoiceNumberDebt, ClientNameDebt," +
                "InvoiceAmountDebt, EmployeeFullNameDebt, INNClientDebt, InvoiseStatusDebt from dbo.InvoicesDebts";

            string connectionString = configuration.GetConnectionString("InvoicesDebt");

            DataTable dataTable = new DataTable();

            SqlDataReader reader;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    reader = command.ExecuteReader();
                    dataTable.Load(reader);
                    reader.Close();
                
                }
                connection.Close();
            }

            return new JsonResult(dataTable);
        }
    }
}

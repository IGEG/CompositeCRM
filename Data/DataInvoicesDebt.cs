using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using CompositeCRM.Models;
using System.Threading.Tasks;

namespace CompositeCRM.Data
{
    public class DataInvoicesDebt : IDataInvoicesDebt
    {
        private readonly IConfiguration configuration;
        public DataInvoicesDebt(IConfiguration conf)
        {
            configuration = conf;
        }

        public async Task<JsonResult> ChangeInvoicesDebtAsync(InvoicesDebt invoicesDebt)
        {
            string query = @"update InvoicesDebts set
       DepartmentNameDebt = N'" + invoicesDebt.DepartmentNameDebt +
       @"',DateInvoicesDebt ='" + invoicesDebt.DateInvoicesDebt +
       @"',InvoiceNumberDebt =" + invoicesDebt.InvoiceNumberDebt +
       @",ClientNameDebt = '" + invoicesDebt.ClientNameDebt +
       @"',InvoiceAmountDebt = " + invoicesDebt.InvoiceAmountDebt +
       @",EmployeeFullNameDebt = N'" + invoicesDebt.EmployeeFullNameDebt +
       @"',INNClientDebt = " + invoicesDebt.INNClientDebt +
       @",InvoiseStatusDebt = '" + invoicesDebt.InvoiseStatusDebt +
       @"' where Id = "+invoicesDebt.Id+@"
       ";


            string connectionString = configuration.GetConnectionString("InvoicesDebt");

            DataTable dataTable = new DataTable();

            SqlDataReader reader;

            using (SqlConnection connection = new SqlConnection(connectionString))
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

        public async Task<JsonResult> DeleteInvoicesDebtAsync(int Id)
        {
            string query = @"delete from InvoicesDebts where Id = "+Id+@"";

            string connectionstring = configuration.GetConnectionString("InvoicesDebt");

            DataTable data = new DataTable();
            SqlDataReader reader;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        reader = await command.ExecuteReaderAsync();
                        data.Load(reader);
                        reader.Close();
                    }
                }
                connection.Close();
            }
            return new JsonResult("Данные успешно удалены");
        }

        public async Task<JsonResult> EditInvoicesDebtAsync(InvoicesDebt invoicesDebt)
        {
            string query = @"insert into InvoicesDebts values (N'" + invoicesDebt.DepartmentNameDebt + @"','" + invoicesDebt.DateInvoicesDebt + @"'," + invoicesDebt.InvoiceNumberDebt +
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
                    reader = await command.ExecuteReaderAsync();
                    dataTable.Load(reader);
                    reader.Close();

                }
                connection.Close();
            }

            return new JsonResult("Данные добавлены!");
        }

        public async Task<JsonResult> GetAllAnvoicesDebtAsync()
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
                    reader = await command.ExecuteReaderAsync();
                    dataTable.Load(reader);
                    reader.Close();

                }
                connection.Close();
            }

            return new JsonResult(dataTable);
        }

        public async Task<JsonResult> GetInvoicesDebtAsync(int Id)
        {
            string query = @"select DepartmentNameDebt, DateInvoicesDebt, InvoiceNumberDebt, ClientNameDebt," +
                "InvoiceAmountDebt, EmployeeFullNameDebt, INNClientDebt, InvoiseStatusDebt from dbo.InvoicesDebts where Id="+Id+@"";

            string connectionString = configuration.GetConnectionString("InvoicesDebt");

            DataTable dataTable = new DataTable();

            SqlDataReader reader;

            using (SqlConnection connection = new SqlConnection(connectionString))
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
    }
}

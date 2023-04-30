using System.Data;
using System.Data.SqlClient;

namespace Server.Implementation
{
    public class BaseImplementation
    {
        string stringConnection = @"Server=ReciclajeII.mssql.somee.com;Database=ReciclajeII; User=reciclaje000000_SQLLogin_1; Password=a8g1enzusy; TrustServerCertificate=true;";

        public SqlCommand CreateBasicCommand()
        {
            SqlConnection connection = new SqlConnection(stringConnection);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            return command;
        }

        public SqlCommand CreateBasicCommand(string query)
        {
            SqlConnection connection = new SqlConnection(stringConnection);
            SqlCommand command = new SqlCommand(query, connection);
            return command;
        }


        public int ExecuteBasicCommand(SqlCommand command)
        {
            try
            {
                command.Connection.Open();
                return command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public DataTable ExecuteDataTableCommand(SqlCommand command)
        {

            try
            {

                command.Connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public void ExecuteDataTableTransaction(SqlCommand command)
        {
            SqlTransaction transaction = command.Connection.BeginTransaction();
            DataTable table = null;
            try
            {

                command.Connection.Open();

                command.Transaction = transaction;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);
                transaction.Commit();
            }
            catch (Exception ex)
            {
                command.Transaction.Rollback();
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public SqlDataReader ExecuteDataReaderCommand(SqlCommand command)
        {

            SqlDataReader reader = null;
            try
            {
                command.Connection.Open();
                reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return reader;
        }
    }
}

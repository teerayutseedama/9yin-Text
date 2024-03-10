using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace ReText9yin.DB
{

    public class ConnectDb
    {
        string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\path\\to\\your\\database.accdb";
        OleDbConnection connection = new OleDbConnection();
        public ConnectDb()
        {
            connection.ConnectionString = connectionString;
            connection.Open();
        }

        public DataTable SelectData(string query)
        {


          
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();

                    try
                    {
                        adapter.Fill(dataTable);

                    return dataTable;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    return null!;
                    }
                }
            
        }
        

        public bool SaveData(string query)
        {
            // คำสั่ง SQL INSERT INTO
            //string query = "INSERT INTO YourTableName (Name, Age) VALUES (@Name, @Age)";

           
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    try
                    {
                     
                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"Rows Affected: {rowsAffected}");

                        if (rowsAffected > 0)
                        {
                       
                            Console.WriteLine("Data inserted successfully.");
                        return true;
                    }
                        else
                        {
                            Console.WriteLine("No data inserted.");
                        return false;
                        }
                    }
                    catch (Exception ex)
                    {
             
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
                }
            
        }
    }
}

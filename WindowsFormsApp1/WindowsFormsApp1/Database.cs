using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using static WindowsFormsApp1.ReadFile;
using System.Data;

namespace WindowsFormsApp1
{
    class Database
    {

        public string DatabaseNamefile()
        {
            return $" Data Source = {Environment.CurrentDirectory} \\db.db; Version = 3;New=True;Compress=True;";
        }

        public void ConnectToDatabase()
        {
            using (SQLiteConnection SQLconnection = new SQLiteConnection(DatabaseNamefile()))
            {
                try
                {
                    SQLconnection.Open();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        public void AddRowToDatabase(Request request)
        {
            using (SQLiteConnection SQLconnection = new SQLiteConnection(DatabaseNamefile()))
            {
                try
                {
                    SQLiteCommand command = new SQLiteCommand();
                    command.CommandText = @"INSERT INTO requests (clientId, requestId, name, quantity, price) VALUES (@clientId, @requestId, @name, @quantity, @price)";
                    command.Connection = SQLconnection;
                    command.Parameters.Add(new SQLiteParameter("@clientId", request.clientId));
                    command.Parameters.Add(new SQLiteParameter("@requestId", request.requestId));
                    command.Parameters.Add(new SQLiteParameter("@name", request.name));
                    command.Parameters.Add(new SQLiteParameter("@quantity", request.quantity));
                    command.Parameters.Add(new SQLiteParameter("@price", request.price));

                    SQLconnection.Open();

                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        public void RefreshDatabase(DataGridView dataGridView)
        {
            using (SQLiteConnection SQLconnection = new SQLiteConnection(DatabaseNamefile()))
            {
                try
                {
                    SQLiteCommand command = new SQLiteCommand();
                    command.CommandText = @"SELECT * FROM requests";
                    command.Connection = SQLconnection;

                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command.CommandText, SQLconnection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        DataRow dataRow = dataTable.Rows[i];

                        dataGridView.Rows.Add();
                        dataGridView.Rows[dataGridView.Rows.Count - 1].Cells["clientIdColumn"].Value = dataRow[0].ToString();
                        dataGridView.Rows[dataGridView.Rows.Count - 1].Cells["requestIdColumn"].Value = dataRow[1].ToString();
                        dataGridView.Rows[dataGridView.Rows.Count - 1].Cells["nameColumn"].Value = dataRow[2].ToString();
                        dataGridView.Rows[dataGridView.Rows.Count - 1].Cells["quantityColumn"].Value = dataRow[3].ToString();
                        dataGridView.Rows[dataGridView.Rows.Count - 1].Cells["priceColumn"].Value = dataRow[4].ToString();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        public void DeleteDatabase()
        {
            using (SQLiteConnection SQLconnection = new SQLiteConnection(DatabaseNamefile()))
            {
                try
                {
                    SQLiteCommand command = new SQLiteCommand();
                    command.CommandText = @"DELETE from requests";
                    command.Connection = SQLconnection;

                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command.CommandText, SQLconnection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

    }
}

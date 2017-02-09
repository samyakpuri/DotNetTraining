using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoBasics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnConnected_Click(object sender, EventArgs e)
        {
            OleDbConnection connection;
            OleDbCommand command;
            DbDataReader reader = null;
            ConnectionStart(out connection, out command);
            command.CommandText = "Select * from employee";            
            await connection.OpenAsync();
            try
            {
                reader = await command.ExecuteReaderAsync();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine("{0} - {1}", reader.GetName(i), reader.GetValue(i));
                    }
                }
            }
            catch(Exception)
            {

            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                    reader.Dispose();
                }
                if(connection.State != ConnectionState.Closed)
                {
                    connection.Close();

                }
                if(connection != null)
                {
                    connection.Dispose();
                }
            }
        }

        private static void ConnectionStart(out OleDbConnection connection, out OleDbCommand command)
        {
            connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\spuri4\Desktop\Database.accdb";

            command = new OleDbCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = "Select * from employee";            

        }

        private async void btnDeConnected_Click(object sender, EventArgs e)
        {
            OleDbConnection connection;
            OleDbCommand command;
            ConnectionStart(out connection, out command);
            command.CommandText = "Select * from employee";
            DataSet dataSet = new DataSet();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);

            await connection.OpenAsync();
            try
            {
                dataAdapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            catch (Exception)
            {

            }
            finally
            {
                if (dataAdapter != null)
                {
                    dataAdapter.Dispose();
                }
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
                if (connection != null)
                {
                    connection.Dispose();
                }
            }
        }

        private async void btnInsert_Click(object sender, EventArgs e)
        {
            OleDbConnection connection;
            OleDbCommand command;
            ConnectionStart(out connection, out command);
            command.CommandText = "Insert into Employee(EmpName,EmpAge,Salary,CompanyName) Values(@EmpName,@EmpAge,@Salary,@CompanyName)";
            command.Parameters.AddWithValue("EmpName","Test3");
            command.Parameters.AddWithValue("EmpAge",23);
            command.Parameters.AddWithValue("Salary",15125);
            command.Parameters.AddWithValue("CompanyName","TestCompany3");

            connection.Open();
            int result = await command.ExecuteNonQueryAsync();
            connection.Close();
            connection.Dispose();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            OleDbConnection connection;
            OleDbCommand command;
            ConnectionStart(out connection, out command);
            command.CommandText = "Delete * from employee where ID = 4";

            connection.Open();
            int result = await command.ExecuteNonQueryAsync();
            connection.Close();
            connection.Dispose();
        }

        private void btnDatasetFromCode_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            DataTable employee = new DataTable();
            employee.Columns.Add("Id",typeof(int));
            employee.Columns.Add("EmpName",typeof(string));
            employee.Columns.Add("EmpAge",typeof(int));
            employee.Columns.Add("Salary",typeof(double));
            employee.Columns.Add("CompanyName",typeof(string));

            DataRow dataRow = employee.NewRow();
            dataRow["Id"] = 4; 
            dataRow["EmpName"] = "Test4";
            dataRow["EmpAge"] = 23;
            dataRow["Salary"] = 235566;
            dataRow["CompanyName"] = "TestCompany2";
            employee.Rows.Add(dataRow);

            employee.Rows.Add(new object[]{5,"Test5",25,264552,"TestCompany4" });

            dataSet.Tables.Add(employee);
            DataView view = employee.DefaultView;
            view.Sort = "EmpAge desc";
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            OleDbConnection connection;
            OleDbCommand command;
            ConnectionStart(out connection, out command);
            command.CommandText = "Update employee set EmpAge=20 where id = 2";
            connection.Open();
            int result = await command.ExecuteNonQueryAsync();
            connection.Close();
            connection.Dispose();
        }

        private void btnGridSelDel_Click(object sender, EventArgs e)
        {
            OleDbConnection connection;
            OleDbCommand command;
            ConnectionStart(out connection, out command);
            command.CommandText = "Delete * from employee where ID = @Value";
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
            command.Parameters.AddWithValue("Value", selectedRow.Cells["Id"].Value);
        }

        private void btnGridUpdate_Click(object sender, EventArgs e)
        {
            OleDbConnection connection;
            OleDbCommand command;
            ConnectionStart(out connection, out command);

            DataTable dataTable = dataGridView1.DataSource as DataTable;
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
            OleDbCommandBuilder commandBuilder = new OleDbCommandBuilder(dataAdapter);
            dataAdapter.Update(dataTable);
        }
    }
}

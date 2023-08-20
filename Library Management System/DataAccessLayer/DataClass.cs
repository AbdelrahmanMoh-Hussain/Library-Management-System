using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Library_Management_System.Data_Access_Layer
{
    class DataClass
    {
        SqlConnection conn = new SqlConnection();
        public DataClass()
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\C#\Library Management System\Library Management System\Library Management System Database.mdf;Integrated Security=True");
        }

        public void Open()
        {
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
           
        }
        public void Close()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        //Read Data
        public DataTable Read(string commandText, SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = commandText;
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }

        public void Execute(string commandText, SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = commandText;
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }
            cmd.ExecuteNonQuery();
        }
    }
}

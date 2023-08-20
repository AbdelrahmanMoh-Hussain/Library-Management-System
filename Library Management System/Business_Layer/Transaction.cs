using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Business_Layer
{
    internal class Transaction
    {
        Data_Access_Layer.DataClass dataClass = new Data_Access_Layer.DataClass();
        public DataTable Load()
        {
            SqlParameter[] parameters = null;
            DataTable dt = dataClass.Read("LoadTransaction", parameters);
            return dt;
        }

        public void Insert(string buyerName, string bookTitle, int sellingPrice, DateTime sellingDate)
        {
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("buyerName", buyerName);
            parameters[1] = new SqlParameter("bookTitle", bookTitle);
            parameters[2] = new SqlParameter("sellingPrice", sellingPrice);
            parameters[3] = new SqlParameter("sellingDate", sellingDate);
            dataClass.Open();
            dataClass.Execute("AddTransaction", parameters);
            dataClass.Close();
        }

        public void Update(int id,string buyerName ,string bookTitle, int price,  DateTime sellingDate)
        {
            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = new SqlParameter("id", id);
            parameters[1] = new SqlParameter("buyerName", buyerName);
            parameters[2] = new SqlParameter("bookTitle", bookTitle);
            parameters[3] = new SqlParameter("sellingPrice", price);
            parameters[4] = new SqlParameter("sellingDate", sellingDate);
            dataClass.Open();
            dataClass.Execute("EditTransaction", parameters);
            dataClass.Close();
        }

        public void Delete(int id)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("id", id);
            dataClass.Open();
            dataClass.Execute("DeleteTransaction", parameters);
            dataClass.Close();
        }

        public DataTable Search(string searchQuery)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("searchQuery", searchQuery);
            DataTable dt = dataClass.Read("SearchTransaction", parameters);
            return dt;
        }
    }
}

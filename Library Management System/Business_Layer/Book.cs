using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Library_Management_System.Business_Layer
{
      
    internal class Book
    {
        Data_Access_Layer.DataClass dataClass = new Data_Access_Layer.DataClass();

        public DataTable Load()
        {
            SqlParameter[] parameters = null;
            DataTable dataTable = new DataTable();
            dataTable = dataClass.Read("LoadBooks", parameters);
            return dataTable;
        }

        //INSERT
        public void Insert(string title, string author, string category, string price, int rate, DateTime publishDate, MemoryStream bookCover)
        {
            SqlParameter[] parameters = new SqlParameter[7];
            parameters[0] = new SqlParameter("title", title);
            parameters[1] = new SqlParameter("author", author);
            parameters[2] = new SqlParameter("category", category);
            parameters[3] = new SqlParameter("price", price);
            parameters[4] = new SqlParameter("rate", rate);
            parameters[5] = new SqlParameter("publishDate", publishDate);
            parameters[6] = new SqlParameter("bookCover", bookCover.ToArray());
            dataClass.Open();
            dataClass.Execute("AddBook", parameters);
            dataClass.Close();
        }

        //UPDATE
        public void Update(int isbn, string title, string author, string category, string price, int rate, DateTime publishDate, MemoryStream bookCover)
        {
            SqlParameter[] parameters = new SqlParameter[8];
            parameters[0] = new SqlParameter("isbn", isbn);
            parameters[1] = new SqlParameter("title", title);
            parameters[2] = new SqlParameter("author", author);
            parameters[3] = new SqlParameter("category", category);
            parameters[4] = new SqlParameter("price", price);
            parameters[5] = new SqlParameter("rate", rate);
            parameters[6] = new SqlParameter("publishDate", publishDate);
            parameters[7] = new SqlParameter("bookCover", bookCover.ToArray());
            dataClass.Open();
            dataClass.Execute("EditBook", parameters);
            dataClass.Close();
        }

        public DataTable GetBookDetails(int isbn)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("isbn", isbn);
            DataTable dataTable = new DataTable();
            dataTable = dataClass.Read("GetBookDetails", parameters);
            return dataTable;
        }

        public void Delete(int isbn)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("isbn", isbn);
            dataClass.Open();
            dataClass.Execute("DeleteBook", parameters);
            dataClass.Close();
        }

        public DataTable Search(string title)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("title", title);
            DataTable dt = dataClass.Read("SearchBook", parameters);
            return dt;
        }

        public int GetBookPrice(int isbn)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("isbn", isbn);
            DataTable dt = dataClass.Read("GetBookPrice", parameters);
            var price = Convert.ToInt32(dt.Rows[0]["Price"]);
            return price;
        }

    }
}

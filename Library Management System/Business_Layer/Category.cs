using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Library_Management_System.Business_Layer
{
    internal class Category
    {
        Data_Access_Layer.DataClass dataClass = new Data_Access_Layer.DataClass();

        public DataTable Load()
        {
            SqlParameter[] parameters = null;
            DataTable dataTable = new DataTable();
            dataTable = dataClass.Read("LoadCategory", parameters);
            return dataTable;
        }

        //INSERT DATA
        public void Insert(string categoryName)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("categoryName", categoryName);
            dataClass.Open();
            dataClass.Execute("AddCategory", parameters);
            dataClass.Close();
        }
        //UPDATE DATA
        public void Update(string categoryName, int id)
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("categoryName", categoryName);
            parameters[1] = new SqlParameter("ID", id);
            dataClass.Open();
            dataClass.Execute("EditCategory", parameters);
            dataClass.Close();
        }

        //DELETE  DATA
        public void Delete(int id)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("ID", id);
            dataClass.Open();
            dataClass.Execute("DeleteCategory", parameters);
            dataClass.Close();
        }

        public DataTable Search(string categoryName)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("categoryName", categoryName);
            DataTable dataTable = new DataTable();
            dataTable = dataClass.Read("SearchCategory", parameters);
            return dataTable;
        }

    }
}

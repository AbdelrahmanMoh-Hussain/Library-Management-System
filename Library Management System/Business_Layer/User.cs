using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Business_Layer
{
    
    internal class User
    {
        Data_Access_Layer.DataClass dataClass = new Data_Access_Layer.DataClass();

        public DataTable Load()
        {
            SqlParameter[] parameters = null;
            DataTable dataTable = new DataTable();
            dataTable = dataClass.Read("LoadUsers", parameters);
            return dataTable;
        }

        public void Insert(string name, string userName, string password, string permission, string state)
        {
            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = new SqlParameter("name", name);
            parameters[1] = new SqlParameter("userName", userName);
            parameters[2] = new SqlParameter("password", password);
            parameters[3] = new SqlParameter("permission", permission);
            parameters[4] = new SqlParameter("state", state);
            dataClass.Open();
            dataClass.Execute("AddUser", parameters);
            dataClass.Close();
        }

        public void Update(int id, string name, string userName, string password, string permission)
        {
            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = new SqlParameter("name", name);
            parameters[1] = new SqlParameter("userName", userName);
            parameters[2] = new SqlParameter("password", password);
            parameters[3] = new SqlParameter("permission", permission);
            parameters[4] = new SqlParameter("id", id);
            dataClass.Open();
            dataClass.Execute("EditUser", parameters);
            dataClass.Close();
        }

        public void Delete(int id)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("id", id);
            dataClass.Open();
            dataClass.Execute("DeleteUser", parameters);
            dataClass.Close();
        }

        public void Logout()
        {
            SqlParameter[] parameters = null;
            dataClass.Open();
            dataClass.Execute("UserLogout", parameters);
            dataClass.Close();
        }

        public DataTable Login(string userName, string password)
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("userName", userName);
            parameters[1] = new SqlParameter("password", password);
            DataTable dataTable = new DataTable();
            dataTable = dataClass.Read("UserLogin", parameters);
            return dataTable;
        }

        public void UpdateUserState(string userName, string password)
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("userName", userName);
            parameters[1] = new SqlParameter("password", password);
            dataClass.Open();
            dataClass.Execute("UpdateUserState", parameters);
            dataClass.Close();
        }

        public DataTable GetUsersLogedIn()
        {
            SqlParameter[] parameters = null;
            DataTable dataTable = new DataTable();
            dataTable = dataClass.Read("GetUsersLogedIn", parameters);
            return dataTable;
        }
    }
}

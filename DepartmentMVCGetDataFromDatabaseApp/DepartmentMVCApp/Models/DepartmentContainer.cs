using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DepartmentMVCApp.Models
{
    public class DepartmentContainer
    {
        string connectionString = @"Server=NADIM-PC\SQLEXPRESS; Database = DepartmentDB; Integrated Security = true";
        public IList<Department> GetAllDept()
        {
            IList<Department> departments = new List<Department>();

            SqlConnection aConnection = new SqlConnection(connectionString);
            aConnection.Open();
            SqlCommand aCommand = new SqlCommand("SELECT * FROM t_department", aConnection);
            SqlDataReader reader = aCommand.ExecuteReader();

            while (reader.Read())
            {
                Department aDepartment = new Department();
                aDepartment.Name = reader[1].ToString();
                aDepartment.Code = reader[2].ToString();
                departments.Add(aDepartment);
            }

            aConnection.Close();
            return departments;
        }

        public void Save(Department aDepartment)
        {

            SqlConnection aConnection = new SqlConnection(connectionString);
            aConnection.Open();
            SqlCommand aCommand = new SqlCommand("INSERT INTO t_department values ('" + aDepartment.DepartmentID + "','" + aDepartment.Code + "','" + aDepartment.Name + "')", aConnection);
            aCommand.ExecuteNonQuery();
            aConnection.Close();
        }
    }
}
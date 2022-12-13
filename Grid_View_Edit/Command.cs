using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Grid_View_Edit
{
    public class Command
    {
        SqlConnection con = new SqlConnection(Get_Connection.GetConnect);
        public SqlDataAdapter GetData()
        {
            if(con.State != ConnectionState.Open)
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from Customers1", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter dr=new SqlDataAdapter(cmd);
            con.Close();

            return dr;
        }
        public void Update_Row(string id,string name,string city,string address)
        {
            if (con.State != ConnectionState.Open) con.Open();

            var Id=int.Parse(id);
            SqlCommand cmd = new SqlCommand("update Customers1 set ContactName='" + name + "',City='" + city + "',Address='" + address + "'where CustomerId='"+Id+"'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Delete_Row(int id)
        {
            if(con.State!= ConnectionState.Open) con.Open();

            SqlCommand cmd = new SqlCommand("Delete from Customers1 where CustomerId='" + id + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
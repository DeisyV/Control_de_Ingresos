using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Windows;

namespace GymApp.DataAccess
{
    public class AccessBD
    {
        
        public void ConectarBD()
        {
            //string cadenaConexion = "Data Source=LAPTOP-UC8ND492;Initial Catalog=ShermanGym;Integrated Security=True";
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConectBD"].ConnectionString);         
           
        }
        public object ConsultarTabla(string Procedimiento)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConectBD"].ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Procedimiento;
            cmd.Connection = conn;
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }
        public object ConsultarParametrica(string Tabla)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConectBD"].ConnectionString);
            SqlCommand cmd = new SqlCommand("select Id, Descripcion from " + Tabla +" where Estado = 1", conn);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }

    }
}
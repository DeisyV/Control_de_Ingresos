using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebControlGastos.Models
{
    public class DataAccess     //se realizan las peticiones para el llamado a la bd
    {                           //el modelo de datos es estandar con las parametricas id y descripcion
        public List<SelectListItem> ConsultarParametricas(string Tabla = "")    //funcion publica, nombre de  variable y se recibe variable tipo string y retorna un objeto tipo lista
        // ConectBD   se realizan cambios en la web config los nombres sean los de la bd
        {
            DataSet conec3 = new DataSet(); //variable de fill
            IList<SelectListItem> Lista = new List<SelectListItem>(); //variable tipo lista es con la de abajo IdatataReader

            SqlConnection connec = new SqlConnection(ConfigurationManager.ConnectionStrings["ConectBD"].ConnectionString); //el nombre de connec es cualquiera es una variable. ConectBD y connectionString se saca de la web config
            connec.Open();   //se abre la conexion a la bd 
            SqlCommand conec1 = new SqlCommand();  // que comando se ejecutan en la bd
            conec1.CommandType = CommandType.Text;  //se configura tipo de comando, texto
            conec1.CommandText = "SELECT Id, Descripcion FROM "+ Tabla +" WHERE Estado = 1;"; //ejecutar procedimientos almacenados, sentencia a realizar, vamos a la BD y creamos el query y pegamos id y descripcion son quemados y concatenamos la tabla de arriba
            conec1.Connection = connec; //parametros de conexion  con la variable de arriba (connec)
            SqlDataAdapter conec2 = new SqlDataAdapter(conec1); //funcion adapter, variable, ejecutar dentro de los () el nombre de la configuracion. conec1
            conec2.Fill(conec3);//fill=llenar. arriba se declara la variable. conec2 retorna objeto tipo data set. arriba se coloca dataset y variable nueva
            connec.Close(); //siempre se debe cerrar la conexion -- arriba se declara otra variable tipo lista
            IDataReader dataReader = null; //cetear "enlazar" la lista con los parametros que tiene asociado el dataset
            dataReader = conec3.Tables[0].CreateDataReader();
            while(dataReader.Read())
            {
                Lista.Add(new System.Web.Mvc.SelectListItem { Value = dataReader["Id"].ToString().ToUpper(), Text = dataReader["Descripcion"].ToString() });
            } //creamos un data reader, ceteamos el dataset, leemos todos los datos que tiene el data reader en este casoseria el dataset que es conec3 hereda la info que tiene el sqladapter. 
              //vamos a la variable lista, adicionarleel item para el value, las listas tienen 2 propiedades que es el VALUE =Id y TEXT= descripcion  que es la parte grafica
            return Lista.ToList(); //retonra la variable lista
        }

        public void CrearPersona()
        {

        }
    }
}
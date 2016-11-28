using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using view_mobile_resto.Clases;
using System.Data;
using System.Data.SqlServerCe;

namespace view_mobile_resto.Controller
{
    public class TrabajarCategoria
    {
        public static List<Categoria> lista_categoria() {
            List<Categoria> lista = new List<Categoria>();

            SqlCeConnection cnn = new SqlCeConnection();
            // Se setea la cadae de conexion
            cnn.ConnectionString = "Data Source=" +
                System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\RestoDB.sdf; " +
                "Persist Security Info=False;";

            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = "select * from Categoria";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cnn.Open();

            // Cargarmos el resultado en una Lista
            SqlCeDataReader reader = cmd.ExecuteReader();
            while (reader.Read() == true)
            {
                Categoria categoria = new Categoria();
                categoria.Id = (int)reader[0];
                categoria.Des = (String)reader[1];
                //categoria.Img = (String)reader[2];
                lista.Add(categoria);
            }
            cnn.Close();
            return lista;
        }

        public static Categoria traer_categoria(int id_categoria) {
            SqlCeConnection cnn = new SqlCeConnection();
            Categoria categoria = new Categoria();
            // Se setea la cadae de conexion
            cnn.ConnectionString = "Data Source=" +
                System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\RestoDB.sdf; " +
                "Persist Security Info=False;";
            SqlCeCommand cmd = new SqlCeCommand("SELECT * FROM Categoria WHERE Cat_Id=@cat_id", cnn);
            cmd.Parameters.AddWithValue("@cat_id", id_categoria);
            cnn.Open();
            SqlCeDataReader reader = cmd.ExecuteReader();
            while (reader.Read() == true)
            {
                categoria.Id = (int)reader[0];
                categoria.Des = (string)reader[1];
                categoria.Img = (string)reader[2];
            }
            cnn.Close();
            return categoria;
        }
    }
}

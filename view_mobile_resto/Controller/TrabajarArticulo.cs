using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using view_mobile_resto.Clases;
using System.Data.SqlServerCe;
using System.Data;

namespace view_mobile_resto.Controller
{
    public class TrabajarArticulo
    {
        public static List<Articulo> buscar_articulo(int id) {
            List<Articulo> lista = new List<Articulo>();
            SqlCeConnection cnn = new SqlCeConnection();
            // Se setea la cadae de conexion
            cnn.ConnectionString = "Data Source=" +
                System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\RestoDB.sdf; " +
                "Persist Security Info=False;";

            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = "select * from Articulo where Cat_Id=@cat_id";
            cmd.Parameters.AddWithValue("@cat_id", id);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cnn.Open();

            // Cargarmos el resultado en una Lista
            SqlCeDataReader reader = cmd.ExecuteReader();
            while (reader.Read() == true)
            {
                Articulo articulo = new Articulo();
                articulo.ArtId = (int)reader[0];
                articulo.ArtDes = (String)reader[1];
                articulo.Cat = (int)reader[2];
                articulo.Um = (int)reader[3];
                articulo.Precio = Convert.ToDouble(reader[4]);
                articulo.Img = (String)reader[5];
                lista.Add(articulo);
            }
            cnn.Close();
            return lista;
        }

        public static Articulo traer_articulo(int id_articulo) {
            Articulo articulo = new Articulo();
            SqlCeConnection cnn = new SqlCeConnection();
            cnn.ConnectionString = "Data Source=" +
                System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\RestoDB.sdf; " +
                "Persist Security Info=False;";
            cnn.Open();
            SqlCeCommand Query = new SqlCeCommand("SELECT * FROM Articulo WHERE Art_Id=@art_id", cnn);
            Query.Parameters.AddWithValue("@art_id", id_articulo);
            SqlCeDataReader reader = Query.ExecuteReader();
            while (reader.Read() == true)
            {
                articulo.ArtId = (int)reader[0];
                articulo.ArtDes = (string)reader[1];
                articulo.Cat = (int)reader[2];
                articulo.Um = (int)reader[3];
                articulo.Precio = Convert.ToDouble(reader[4]);
                articulo.Img = (string)reader[5];
            }
            cnn.Close();
            return articulo;
        }

        public static ArticuloUtil traer_articulo_util(int id_articulo)
        {
            ArticuloUtil articuloUtil = new ArticuloUtil();
            SqlCeConnection cnn = new SqlCeConnection();
            cnn.ConnectionString = "Data Source=" +
                System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\RestoDB.sdf; " +
                "Persist Security Info=False;";
            cnn.Open();
            SqlCeCommand Query = new SqlCeCommand("SELECT a.Art_Id, a.Art_Descrip, c.Cat_Descrip, um.UM_Descrip, a.Art_Precio, a.Art_Imagen FROM Articulo a INNER JOIN Categoria c ON a.Cat_Id = c.Cat_Id INNER JOIN Unidad_Medida um ON a.UM_Id = um.UM_Id WHERE a.Art_Id=@art_id", cnn);
            Query.Parameters.AddWithValue("@art_id", id_articulo);
            SqlCeDataReader reader = Query.ExecuteReader();
            while (reader.Read() == true)
            {
                articuloUtil.Art_id = (int)reader[0];
                articuloUtil.Art_descrip = (string)reader[1];
                articuloUtil.Cat_descrip = (string)reader[2];
                articuloUtil.Um_descrip = (string)reader[3];
                articuloUtil.Art_precio = Convert.ToDouble(reader[4]);
                articuloUtil.Art_imagen = (string)reader[5];
            }
            cnn.Close();
            return articuloUtil;
        }
    }
}

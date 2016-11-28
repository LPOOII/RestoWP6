using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using System.Data;
using view_mobile_resto.Clases;


namespace view_mobile_resto.Controller
{
    public class TrabajarMesas
    {
        public static List<Mesa> traer_mesas()
        {
            List<Mesa> lista = new List<Mesa>();

            SqlCeConnection cnn = new SqlCeConnection();
            // Se setea la cadae de conexion
            cnn.ConnectionString = "Data Source=" +
                System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\RestoDB.sdf; " +
                "Persist Security Info=False;";

            SqlCeCommand cmd = new SqlCeCommand();
            cmd.CommandText = "select * from Mesa";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cnn.Open();

            // Cargarmos el resultado en una Lista
            SqlCeDataReader reader = cmd.ExecuteReader();
            while (reader.Read() == true)
            {
                Mesa me = new Mesa();
                me.Id = (int)reader[0];
                me.Pos = (int)reader[1];
                me.Estado = (int)reader[2];
                lista.Add(me);
            }
            cnn.Close();

            return lista;
        }

        public static void cambiar_estado_mesa(int id_mesa, int estado_mesa)
        {
            SqlCeConnection cnn = new SqlCeConnection();
            cnn.ConnectionString = "Data Source=" +
                System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\RestoDB.sdf; " +
                "Persist Security Info=False;";
            cnn.Open();
            SqlCeCommand Query = new SqlCeCommand("UPDATE Mesa SET Mesa_Estado=@mesa_estado WHERE Mesa_Id=@mesa_id", cnn);
            Query.Parameters.AddWithValue("@mesa_estado", estado_mesa);
            Query.Parameters.AddWithValue("@mesa_id", id_mesa);
            Query.ExecuteNonQuery();
            cnn.Close();
        }
    }
}

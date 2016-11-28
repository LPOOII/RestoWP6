using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlServerCe;
using view_mobile_resto.Clases;

namespace view_mobile_resto.Controller
{
    public class TrabajarPedido
    {
        public static int iniciar_pedido(int mesa){            
            SqlCeConnection cnn = new SqlCeConnection();
            cnn.ConnectionString = "Data Source=" + 
                System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\RestoDB.sdf; " +
                "Persist Security Info=False;";
            cnn.Open();
            SqlCeCommand Query = new SqlCeCommand("INSERT INTO Pedido(Mesa_Id, Ped_Fecha, Ped_Comensales, Ped_Facturado) VALUES(@mesa_id, @ped_fecha, @ped_comensales, @ped_facturado)", cnn);            
            Query.Parameters.AddWithValue("@mesa_id", mesa);
            Query.Parameters.AddWithValue("@ped_fecha", DateTime.Now);
            Query.Parameters.AddWithValue("@ped_comensales", 0);
            Query.Parameters.AddWithValue("@ped_facturado", false);
            Query.ExecuteNonQuery();
            Object id = 0;
            SqlCeCommand LastInserted = new SqlCeCommand("SELECT @@IDENTITY", cnn);
            SqlCeDataReader reader = LastInserted.ExecuteReader();
            while (reader.Read() == true)
            {
                id = (Object)reader[0];
                Console.WriteLine(reader[0]);
            }
            cnn.Close();
            return Convert.ToInt32(id);
        }

        public static Pedido traer_pedido(int id_mesa) {
            SqlCeConnection cnn = new SqlCeConnection();
            Pedido pedido = new Pedido();
            cnn.ConnectionString = "Data Source=" +
                System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\RestoDB.sdf; " +
                "Persist Security Info=False;";
            cnn.Open();
            SqlCeCommand Query = new SqlCeCommand("SELECT * FROM Pedido WHERE Mesa_Id=@mesa_id AND Ped_Facturado=@ped_facturado", cnn);
            Query.Parameters.AddWithValue("@mesa_id", id_mesa);
            Query.Parameters.AddWithValue("@ped_facturado", false);
            SqlCeDataReader reader = Query.ExecuteReader();
            while (reader.Read() == true)
            {
                pedido.Id = (int)reader[0];
                pedido.Mesa = (int)reader[1];
                pedido.Fecha = (DateTime)reader[2];
                pedido.Comensales = (int)reader[3];
                pedido.Fec = (bool)reader[4];
            }
            cnn.Close();
            return pedido;
        }

        public static void actualizar_pedido(int id_pedido, int ped_comensales, bool ped_facturado) {
            SqlCeConnection cnn = new SqlCeConnection();
            cnn.ConnectionString = "Data Source=" +
                System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\RestoDB.sdf; " +
                "Persist Security Info=False;";
            cnn.Open();
            SqlCeCommand Query = new SqlCeCommand("UPDATE Pedido SET Ped_Comensales=@ped_comensales, Ped_Facturado=@ped_facturado WHERE Ped_Id=@ped_id", cnn);
            Query.Parameters.AddWithValue("@ped_id", id_pedido);
            Query.Parameters.AddWithValue("@ped_comensales", ped_comensales);
            Query.Parameters.AddWithValue("@ped_facturado", ped_facturado);
            Query.ExecuteNonQuery();
            cnn.Close();
        }
    }
}

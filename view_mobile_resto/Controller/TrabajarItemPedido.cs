using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using view_mobile_resto.Clases;
using System.Data;
using System.Data.SqlServerCe;


namespace view_mobile_resto.Controller
{
    public class TrabajarItemPedido
    {
        public static void agregar_item_pedido(ItemPedido item) {
            SqlCeConnection cnn = new SqlCeConnection();
            cnn.ConnectionString = "Data Source=" +
                System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\RestoDB.sdf; " +
                "Persist Security Info=False;";
            cnn.Open();
            SqlCeCommand Query = new SqlCeCommand("INSERT INTO Items_Pedido(Ped_Id, Art_Id, Precio, Cantidad, Importe) VALUES(@ped_id, @art_id, @precio, @cantidad, @importe)", cnn);
            Query.Parameters.AddWithValue("@ped_id", item.Pedido);
            Query.Parameters.AddWithValue("@art_id", item.Art);
            Query.Parameters.AddWithValue("@precio", item.Precio);
            Query.Parameters.AddWithValue("@cantidad", item.Cant);
            Query.Parameters.AddWithValue("@importe", item.Importe);
            Query.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable traer_items_por_pedido(int id_pedido) {
            SqlCeConnection cnn = new SqlCeConnection();
            cnn.ConnectionString = "Data Source=" +
                System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\RestoDB.sdf; " +
                "Persist Security Info=False;";
            cnn.Open();
            string sql = "SELECT ip.Item_Pedido_Id as ID, a.Art_Descrip as Descrip, ip.Precio as Precio, ip.Cantidad as Cantidad, ip.Importe as Importe FROM Items_Pedido ip"
                + " INNER JOIN Articulo a ON ip.Art_Id = a.Art_Id WHERE ip.Ped_Id=@ped_id";

            SqlCeCommand cmd = new SqlCeCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@ped_id", id_pedido);
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        public static double calcular_facturacion(int id_pedido) {
            double total = 0;
            SqlCeConnection cnn = new SqlCeConnection();
            cnn.ConnectionString = "Data Source=" +
                System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\RestoDB.sdf; " +
                "Persist Security Info=False;";
            cnn.Open();
            SqlCeCommand Query = new SqlCeCommand("SELECT SUM(Importe) FROM Items_Pedido WHERE Ped_Id=@ped_id", cnn);
            Query.Parameters.AddWithValue("@ped_id", id_pedido);
            SqlCeDataReader reader = Query.ExecuteReader();
            while (reader.Read() == true)
            {
                total = Convert.ToDouble(reader[0]);
            }
            cnn.Close();
            return total;
        }

        public static void eliminar_item(int id_item) {
            SqlCeConnection cnn = new SqlCeConnection();
            cnn.ConnectionString = "Data Source=" +
                System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\RestoDB.sdf; " +
                "Persist Security Info=False;";
            cnn.Open();
            SqlCeCommand Query = new SqlCeCommand("DELETE FROM Items_Pedido WHERE Item_Pedido_Id=@item_id", cnn);
            Query.Parameters.AddWithValue("@item_id", id_item);
            Query.ExecuteNonQuery();
            cnn.Close();
        }
    }
}

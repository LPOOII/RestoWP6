using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace view_mobile_resto.Clases
{
   public class ItemPedido
    {
        private int id;
        private int pedido;
        private int art;
        private Double precio;
        private int cant;
        private Double importe;

        public Double Importe
        {
            get { return importe; }
            set { importe = value; }
        }

        public int Cant
        {
            get { return cant; }
            set { cant = value; }
        }

        public Double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public int Art
        {
            get { return art; }
            set { art = value; }
        }

        public int Pedido
        {
            get { return pedido; }
            set { pedido = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}

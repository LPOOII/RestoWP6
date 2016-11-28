using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace view_mobile_resto.Clases
{
    public class Pedido
    {
        private int id;
        private int mesa;
        private DateTime fecha;
        private int comensales;
        private Boolean fec;

        public Boolean Fec
        {
            get { return fec; }
            set { fec = value; }
        }

        public int Comensales
        {
            get { return comensales; }
            set { comensales = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public int Mesa
        {
            get { return mesa; }
            set { mesa = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}

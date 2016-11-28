using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace view_mobile_resto.Clases
{
    public class UnidadMedida
    {
        private int id;
        private String des;
        private String abre;

        public String Abre
        {
            get { return abre; }
            set { abre = value; }
        }

        public String Des
        {
            get { return des; }
            set { des = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}

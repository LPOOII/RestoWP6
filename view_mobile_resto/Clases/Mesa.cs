using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace view_mobile_resto.Clases
{
    public class Mesa
    {
        private int id;
        private int pos;
        private int estado;

        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public int Pos
        {
            get { return pos; }
            set { pos = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}

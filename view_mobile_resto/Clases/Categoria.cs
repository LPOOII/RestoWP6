using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace view_mobile_resto.Clases
{
    public class Categoria
    {
        private int id;
        private String des;
        private String img;

        public String Img
        {
            get { return img; }
            set { img = value; }
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

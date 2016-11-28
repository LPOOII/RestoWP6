using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace view_mobile_resto.Clases
{
    public class ArticuloUtil
    {
        private int art_id;

        public int Art_id
        {
            get { return art_id; }
            set { art_id = value; }
        }
        private String art_descrip;

        public String Art_descrip
        {
            get { return art_descrip; }
            set { art_descrip = value; }
        }
        private String cat_descrip;

        public String Cat_descrip
        {
            get { return cat_descrip; }
            set { cat_descrip = value; }
        }
        private String um_descrip;

        public String Um_descrip
        {
            get { return um_descrip; }
            set { um_descrip = value; }
        }
        private double art_precio;

        public double Art_precio
        {
            get { return art_precio; }
            set { art_precio = value; }
        }
        private String art_imagen;

        public String Art_imagen
        {
            get { return art_imagen; }
            set { art_imagen = value; }
        }

        public ArticuloUtil() { }
    }
}

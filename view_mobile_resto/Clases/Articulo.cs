using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace view_mobile_resto.Clases
{
    public class Articulo
    {
        private int artId;
        private String artDes;
        private int cat;
        private int um;
        private double precio;
        private String img;

        public String Img
        {
            get { return img; }
            set { img = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public int Um
        {
            get { return um; }
            set { um = value; }
        }

        public int Cat
        {
            get { return cat; }
            set { cat = value; }
        }

        public String ArtDes
        {
            get { return artDes; }
            set { artDes = value; }
        }

        public int ArtId
        {
            get { return artId; }
            set { artId = value; }
        }

    }
}

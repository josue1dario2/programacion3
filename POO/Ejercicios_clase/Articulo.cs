using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_clase
{
    internal class Articulo
    {
        private int codArticulo;
        private float precio;
        private int codMarca;

        public int CodArticulo
        {
            get { return codArticulo; }
            set { codArticulo = value; }
        }
        public float Precio { get; set; }
        public int CodMarca
        {
            get { return codMarca; }
            set {  
                if(value > 0 && value < 11 )
                    codMarca = value;
                else { codMarca = -1; }
            }
        }
    }
}

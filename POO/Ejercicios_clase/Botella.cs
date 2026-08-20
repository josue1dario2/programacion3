using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_clase
{
    internal class Botella
    {
        private int capacidad;
        private string color;
        private string material;

       public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }
        public string Color
        {
            get { return color; }
            set {  color = value; }
        }
        public string Material
        {
            get { return material; }
            set {  material = value; }
        }
    }
}

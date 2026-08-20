using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_clase
{
    internal class Persona
    {
        private int edad;
        private float sueldo;
        private string nombre;

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public float Sueldo
        {
            get { return sueldo; }
            set {  sueldo = value; }
        }
        public string Nombre
        {
            get { return  nombre; }
            set {  nombre = value; }
        }

    }
}

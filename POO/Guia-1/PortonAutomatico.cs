using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_1
{
    internal class PortonAutomatico
    {
        public PortonAutomatico() {
            this.Apertura = 0;
        }

        public PortonAutomatico(int apertura) { 
            if(apertura < 0) apertura = 0;
            else if(apertura > 100) apertura = 100;
            this.Apertura = apertura;
        }
        public int Apertura { get; set; }
        public bool EstadoCerrado
        {
            get {  return Apertura == 0; }
        }
        public bool EstaAbiertoCompleto
        {
            get { return Apertura == 100; }
        }

        public void Abrir()
        {
            if (Apertura == 100) {
                Console.WriteLine("Ya está abierto al 100%");
            }
            else
            {
                this.Apertura = 100;
            }
            
        }
        public void Abrir(int porcentaje)
        {

            if (porcentaje < 1 || porcentaje > 99)
            {
                Console.WriteLine("Porcentaje inválido. Debe ser 1-99");
            }
            else
            {
                Apertura = porcentaje;
            }
        }
        public void AbrirPeatonal()
        {
            Abrir(20);
        }
        public void Cerrar()
        {
            if (Apertura == 0)
            {
                Console.WriteLine("Ya está completamente cerrado");
            }
            else
            {
                this.Apertura = 0;
            }
        }
        public string MostrarEstado()
        {
            if (this.Apertura == 100)
            {
                return "Abierto total (100%)";
            }
            else if (this.Apertura > 0) {
                return "Abierto parcial (" + Apertura + "%)";
            }
            else
            {
                return "Cerrado";
            }
        }
        public void Stop()
        {
            Console.WriteLine("Movimiento detenido");
        }
        public bool Toggle()
        {
            if(Apertura == 0)
            {
                Apertura = 100;
                return true;
            }
            else
            {
                Apertura = 0;
                return false;
            }
        }
    }
}

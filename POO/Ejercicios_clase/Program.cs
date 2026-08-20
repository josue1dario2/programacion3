using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Primer lote con 10 registros de productos, cada producto tiene:
                - codigo articulo (3 digito no correlativos)
                - precio
                - codigo de marca (1 a 10)
            Segundo lote las ventas de la semana, cada venta tiene:
                - codigo articulo
                - cantidad
                - codigo cliente (1 al 100)
            Este lote corta con codigo de cliente cero
             */
             

            // crear lo registros de productos
            Articulo[] articulos = new Articulo[10] ;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese los datos del producto");
                Console.WriteLine("Código:");
                articulos[i].CodArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio");
                articulos[i].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Código de Marca:");
                articulos[i].CodMarca = int.Parse(Console.ReadLine());
            }
            
        }
    }
}

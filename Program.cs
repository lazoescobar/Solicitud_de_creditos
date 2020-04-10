using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solicitud_de_creditos
{
    class Program
    {
        static void Main(string[] args)
        {


            Menu men = new Menu();

            String nombre = men.solicitarNombre();
            String apellido = men.solicitarApellido();
            String monto = men.solicitarSueldo();
            

            Sueldo suel = new Sueldo(monto);

            Cliente clie = new Cliente(nombre, apellido, suel);


            String tipo = men.solicitartipoCliente(clie);

            clie.setTipo(tipo);




            Console.Out.WriteLine("Nombre cliente : " + clie.getNombre() + "\n" );
            Console.Out.WriteLine("Apellido cliente : " + clie.getApellido() + "\n" );
            Console.Out.WriteLine("Sueldo $ : " + clie.getSueldo().getMonto() + "\n" );
            Console.Out.WriteLine("tipo cliente : " + clie.getTipo() + "\n");


            Console.ReadKey();
        }
    }
}

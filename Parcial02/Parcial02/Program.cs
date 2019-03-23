using System;
using System.Linq;

namespace Parcial02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] ss = new int[6];
            int[] sm = new int[6];
            int contador_ss = 1;
            int contador_sm = 1;
            Console.WriteLine("Autor AC100816 Rafael Ernesto Alfaro Contreras");
            do
            {
                Console.WriteLine($"Ingrese el Numero de becas la sede {contador_ss} San Salvador");
                ss[contador_ss] = Convert.ToInt32(Console.ReadLine());
                contador_ss++;
            } while (contador_ss < 6);
            do
            {
                Console.WriteLine($"Ingrese el Numero de becas la sede {contador_sm} San Miguel");
                sm[contador_sm] = Convert.ToInt32(Console.ReadLine());
                contador_sm++;
            } while (contador_sm < 6);
            int becas_ss = ss.Sum(x => Convert.ToInt32(x));
            int becas_sm = sm.Sum(x => Convert.ToInt32(x));
            if (becas_ss > becas_sm)
            {
                Console.WriteLine("Sede San Salvador tiene mayor numero de becas");
            }
            else if (becas_sm > becas_ss)
            {
                Console.WriteLine("Sede San Miguel tiene mayor numero de becas");
            }
            else if (becas_sm == becas_ss)
            {
                Console.WriteLine("Las dos sedes tienen el mismo numero de solicitudes");
            }
            Console.ReadKey();

        }
    }
}

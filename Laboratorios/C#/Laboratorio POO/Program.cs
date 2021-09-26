using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta();

            Console.WriteLine("Ingrese su nombre:");
            String n = Console.ReadLine();
            cuenta1.setNombre(n);
            Console.WriteLine("\nBienvenido {0}, su número de cuenta es {1}", cuenta1.getNombre(), cuenta1.getNumero());

            Console.WriteLine("\nSeleccione el tipo de cuenta (escriba el número):\n\n1. Ahorros\n2. Corriente");
            while (true)
            {
                string t = Console.ReadLine();
                if (t == "1")
                {
                    cuenta1.setTipo("Ahorros");
                    cuenta1.setSaldo(50000);
                    Console.WriteLine("\nLa cuenta seleccionada ha sido 'Ahorros'");
                    break;
                }
                else if (t == "2")
                {
                    cuenta1.setTipo("Corriente");
                    cuenta1.setSaldo(100000);
                    Console.WriteLine("\nLa cuenta seleccionada ha sido 'Corriente'");
                    break;
                }
                else
                {
                    Console.WriteLine("\nDigite un valor válido\n");
                }
            }
            
            while (true)
            {
                Console.WriteLine("\nQué acción quiere realizar?\n\n1. Consignar dinero\n2. Retirar dinero\n3. Ver saldo\n4. Ver todos los datos\n5. Salir");
                var accion = Console.ReadLine();
                if (accion == "1")
                {
                    Console.WriteLine("\nCuánto dinero quiere consignar? (Su saldo actual es: {0})", cuenta1.getSaldo());
                    double consigna = double.Parse(Console.ReadLine());
                    cuenta1.consignarDinero(consigna);
                }
                if (accion == "2")
                {
                    Console.WriteLine("\nCuánto dinero quiere retirar? (Su saldo actual es: {0})", cuenta1.getSaldo());
                    double retiro = double.Parse(Console.ReadLine());
                    cuenta1.retirarDinero(retiro);
                }
                if (accion == "3")
                {
                    cuenta1.verSaldo();
                }
                if (accion == "4")
                {
                    cuenta1.verDatos();
                }
                if (accion == "5")
                {
                    break;
                }
            }
        }
    }
}

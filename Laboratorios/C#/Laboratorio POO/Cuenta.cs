using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_POO
{
    class Cuenta
    {
        // Atributos
        private int numero;
        private String nombre;
        private double saldo;
        private String tipo;

        public Cuenta()
        {
            Random rnd = new Random();
            numero = rnd.Next(10000000, 99999999);

        }

        // Get y set
        public int getNumero()
        {
            return this.numero;
        }
        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }
        public string getNombre()
        {
            return this.nombre;
        }
        public void setTipo(String tipo)
        {
            this.tipo = tipo;
        }
        public void setSaldo(double saldo)
        {
            this.saldo = saldo;
        }
        public double getSaldo()
        {
            return this.saldo;
        }

        // Métodos
        public void consignarDinero(double consigna)
        {
            if (consigna > 0)
            {
                this.saldo += consigna;
                Console.WriteLine("Su saldo después de la consigna es: " + saldo);
            }
            else
            {
                Console.WriteLine("Ingrese un valor válido");
            }
        }

        public void retirarDinero(double retiro)
        {
            if (retiro <= this.saldo)
            {
                this.saldo -= retiro;
                Console.WriteLine("Su saldo después del retiro es: " + saldo);
            }
            else
            {
                Console.WriteLine("Ingrese un valor válido");
            }
        }

        public void verSaldo()
        {
            Console.WriteLine("\nSu saldo actual es: " + saldo);
        }

        public void verDatos()
        {
            Console.WriteLine("\nNombre: {0}\nNúmero de cuenta: {1}\nTipo de cuenta: {2}\nSaldo de la cuenta: {3}"
                , nombre, numero, tipo, saldo);
        }
    }
}

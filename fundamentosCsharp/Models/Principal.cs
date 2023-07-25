using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentosCsharp.Models
{
    internal class Principal
    {
        public void calculadora() 
        {
            int opc = -1;
            Operaciones operaciones = new Operaciones();
            while(opc!=0)
            {
                try
                {
                    Console.WriteLine("SELECCIONA UNA OPERACION:");
                    Console.WriteLine("1) suma\n2) resta\n3) multiplicacion\n4) division");
                    Console.WriteLine("Pulsa enter o 0 para salir");
                    opc = int.Parse(Console.ReadLine());
                }catch (System.FormatException) {
                    opc = 0;
                }
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Resultado suma = {0}", operaciones.sumar(leerA(), leerB()));
                        break;
                    case 2:
                        Console.WriteLine("Resultado resta = {0}", operaciones.restar(leerA(), leerB()));
                        break;
                    case 3:
                        Console.WriteLine("Resultado multiplicacion = {0}", operaciones.multiplicar(leerA(), leerB()));
                        break;
                    case 4:
                        Console.WriteLine("Resultado dividir = {0}", operaciones.dividir(leerA(), leerB()));
                        break;
                }
            }
        }
        private int leerA()
        {
            Console.WriteLine("Ingresa A:");
            return int.Parse(Console.ReadLine());
        }
        private int leerB()
        {
            Console.WriteLine("Ingresa B:");
            return int.Parse(Console.ReadLine());
        }
    }
}

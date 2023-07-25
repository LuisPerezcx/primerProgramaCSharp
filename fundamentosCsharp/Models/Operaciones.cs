using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentosCsharp.Models
{
    internal class Operaciones
    {
        public int sumar(int a, int b)
        {
            return a + b;
        }
        public int restar(int a, int b)
        {
            return a - b;
        }
        public int multiplicar(int a, int b) 
        {
            return a * b;
        }
        public float dividir(float a, float b) 
        { 
            return a / b; 
        }
    }
}

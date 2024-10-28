using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_recursividad
{
    class Exponent
    {
        // Calcula el exponente de un número utilizando recursión
        public static int Run(int @base, int exponent)
        {
            // Caso base: 0^x = 1
            if (exponent == 0)
                return 1;
            else
                // Caso recursivo: x^n = x * x^(n-1)
                return @base * Run(@base, exponent - 1);
        }
    }
}

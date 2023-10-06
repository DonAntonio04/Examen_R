using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_R
{
    internal class Examen
    {
       public int Tabla(int z, int i)
        {
            
            if( i < 11)
            {
                Console.WriteLine($" {i} x {z} = {i * z} ");
            }

            Tabla(z, i + 1);

            return i;
        }

        public int Intervalo(int intervaloInferior , int intervaloSuperior)
        {
            if (intervaloInferior < intervaloSuperior)
            {
                for (int i = intervaloInferior; i < intervaloSuperior; i++) 
                {
                    Console.WriteLine(i);
                }

            }

            else 
            {
                for (int i = intervaloInferior; i > intervaloSuperior; i-- )
                {
                    Console.WriteLine(i);
                }
            }

          return intervaloInferior;
        }
    }
}

using System;

namespace Programas
{
    class Program
    {

        /* Esta es la forma de hacerlo "con errores" que le había presentado durante la clase, me había 
        faltado agregar el error correspondiente "OverflowException" y comprobarlo correctamente.*/

        static Boolean overflow(int x, int z){

            Boolean verificador = false;

            try{

                if((x + z) > byte.MaxValue){

                    verificador = true;

                }

            }catch(OverflowException e){

                verificador = true;

            }

            return verificador;

        }

        static Boolean underflow(int x, int z){

            Boolean verificador = false;

            try{

                if((x - z) < byte.MinValue){

                    verificador = true;

                }

            }catch(OverflowException e){

                verificador = true;

            }

            return verificador;

        }

        static void Main(string[] args)
        {

            Console.WriteLine("Detectar Underflow y Overflow");
            Console.WriteLine();
            Console.WriteLine("Rango de valores permitidos para la variable tipo byte: 0-255");
            Console.WriteLine();

            Console.WriteLine("Introduzca el primer número");
            byte x = byte.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca el segundo número");
            byte z = byte.Parse(Console.ReadLine());

            Console.WriteLine();
            
            if(overflow(x, z)){

                // Esto significa que al momento de sumar los numeros introducidos estos sobrepasan el máximo de valores del tipo Byte.
                Console.WriteLine("Overflow detectado (Suma)");

            }
            else if(underflow(x, z)){

                // Esto significa que no habría ningún problema al sumar los numeros introducidos, pero sí al restarlos.
                Console.WriteLine("Underflow detectado (Resta)");

            }
            else{

                // No habría ningún problema si se suman o restan los valores introducidos, permanecerían dentro del rango en ambos casos.
                Console.WriteLine("No se detectaron errores.");
            }

            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
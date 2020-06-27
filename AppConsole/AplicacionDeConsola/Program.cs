using System;

namespace Program
{
    class Suma
    {
        static void Main(string[] args)
        {
            int numero1 = 0;
            int numero2 = 0;
            int numero3 = 0;  //Inicializamos las variables 

            Console.WriteLine("SUMA DE TRES NÚMEROS"); // titulo de nuestro programa de consola
            // 'WriteLine' se utiliza para generar (imprimir) valores

            Console.WriteLine("Ingrese el primer número y presione enter"); // ingresamos el primer numero
            numero1 = Convert.ToInt32(Console.ReadLine());  // 'Convert.ToInt32' convierte un dato tipo string en un dato tipo number 
            // 'ReadLine' Lee la linea y obtiene la entrada 

            Console.WriteLine("Ingrese el segundo número y presione enter");    // ingresamos el segundo numero
            numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer número y preione enter");  //  ingresamos el tercer numero
            numero3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"El resultado es: {numero1} + {numero2} + {numero3} = " + (numero1 + numero2 + numero3));  //concatenamos nuestras variables para realizar la suma

            Console.WriteLine("Presione enter para cerrar el programa");
            Console.ReadKey();  // 'ReadKey toma la tecla preionada qu en este caso seria enter y termina el programa'
        }
    }
}
using System;

namespace Variables
{
    class Program
    {
        static void Main(string[]args)
        {
            byte number = 2; // Utilizado para declarar variables que almacenan valores enteros de 0 a 255.
            int count = 10; // Int representa el numero entero.
            float totalPrice = 20.95f; // Float te permite utilizar decimales.
            char character = 'A'; // Char te permite uilizar letras.
            string FirstName = "Ian"; // String te permite utilizar una cadena de letras.
            bool isWorking = false; // Bool te permite utilizar los valores Cierto o Falso.
            var isCooking = true; // Var permite detectar el tipo de dato.

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(FirstName);
            Console.WriteLine(isWorking);
            Console.WriteLine(isCooking);
        }
    }
    
}
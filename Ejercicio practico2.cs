using System;

namespace Ejercicio_practico2
{
    class Program
    {
        public static void Main(string[] args)
        {
         
            string valorA ="";
            int valorB = 0;
            double valorC = 0.0;
            
            
            Console.WriteLine("Hola, por favor ingresa tu edad para continuar:");
            valorA = Console.ReadLine();
            valorB = Convert.ToInt32(valorA);
            
            
            if(valorB >= 18)
            {
                Console.WriteLine("Nos disculpamos pero usted sobre pasa la edad requerida para ingresar a nuestras instalaciones");
            }
            else
            {
                
                Console.WriteLine(" ");
                Console.WriteLine("Bienvenido");
                Console.WriteLine(" ");

                Console.WriteLine("¿cual es tu altura? escribir en metros");
                valorA = Console.ReadLine();
                valorC = Convert.ToDouble(valorA);
                
                if(valorC >= 1.6)
                {
                Console.WriteLine(" ");
                Console.WriteLine("Puede ir a disfrutar de la casa encantada, el carrusel y a la montaña rusa");    
                }
                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Puede ir a disfrutar de los carros chocones y al carrusel");
                
                }
                
            }
            Console.ReadKey();
        
        }
    }
}   
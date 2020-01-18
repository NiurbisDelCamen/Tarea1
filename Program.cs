using System;

namespace tarea1ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Capitulo 1");
            Console.WriteLine("Ejercicio 1");
            Console.WriteLine("Niurbis");
            Console.WriteLine("Ejercicio 5");
            Console.WriteLine("Estos");
            Console.WriteLine("Son");
            Console.WriteLine("mensajes");
            Console.WriteLine("de prueba.");

            Console.WriteLine("Capitulo 2");
            Console.WriteLine("ejercicio1");
            float perimetro;
            float longitud;
            float nlados;
            Console.WriteLine("Numero de lados : ");
            nlados = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Logitud de lado : ");
            longitud = Convert.ToSingle(Console.ReadLine());
            perimetro = nlados = longitud;
            Console.WriteLine("Perimetro: {0}", perimetro);

            Console.WriteLine("ejercicio 3");
            float radianes, grados;
            Console.WriteLine("Grados: ");
            grados = Convert.ToSingle(Console.ReadLine());
            radianes = (Convert.ToSingle(Math.PI / 180)) * grados;
            Console.WriteLine("Radianes: {0}", radianes);

            Console.WriteLine("ejercicio 5");
            Console.WriteLine("Cantidad de dolares: ");
            double dolares = Convert.ToDouble(Console.ReadLine());
            double euro = 0.86f;
            double dolaresEuro = dolares * euro;
            Console.WriteLine("{0} dolares = {1} Euros", dolares, dolaresEuro);

            Console.WriteLine("capitulo3");
            Console.WriteLine("ejercicio1");
            int numero;
            Console.WriteLine("Numero entero: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if ((numero % 2) == 0)
            {
                Console.WriteLine("El numero {0} es par", numero);
            }
            else
            {
                Console.WriteLine("El numero {0} es impar", numero);
            }
        }
    }
}

using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el valor de n: ");
        int n = int.Parse(Console.ReadLine());
        int suma = 0;
        int contador = 0;
        int numero = 1;

        do
        {
            suma += numero;
            contador++;
            numero += 2;
        } while (contador < n);

       Console.WriteLine($"La suma de los primeros {n} números impares es: {suma}");
    }
    }
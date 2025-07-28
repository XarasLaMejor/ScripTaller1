using System;


class Program
{
    // 1. Función con parámetros por defecto
    static void ImprimirDatos(string nombre, int edad = 18)
    
    {
        Console.WriteLine($"Nombre: {nombre}, Edad: {edad}");
    }

    // 2. Función sin parámetros y sin retorno
    void MostrarBienvenida()
    {
        Console.WriteLine("¡Bienvenido al sistema!");
    }

    // 3. Función que recibe dos números y retorna su promedio
    double CalcularPromedio(int a, int b)
    {
        return (a + b) / 2.0;
    }

    // 4. Función que devuelve la fecha actual
    DateTime ObtenerFechaActual()
    {
        return DateTime.Now;
    }

    // 5. Función que recibe una cadena y devuelve su longitud
    int ContarCaracteres(string texto)
    {
        return texto.Length;
    }

    // 6. Función que evalúa si un número es par
    bool EsPar(int numero)
    {
        return numero % 2 == 0;
    }

    // 7. Función con uso de ref
    static void Incrementar(ref int valor)
    {
        valor++;
    }

    // 8. Función que recibe una lista y muestra sus elementos
    void ImprimirLista(List<string> elementos)
    {
        foreach (string item in elementos)
            Console.WriteLine(item);
    }

    // 9. Función recursiva que calcula el factorial de un número
    int Factorial(int n)
    {
        if (n <= 1) return 1;
        return n * Factorial(n - 1);
    }

    // 10. Función que retorna el mayor de dos números
    int Maximo(int a, int b)
    {
        return a > b ? a : b;
    }

    // 11. Función que concatena dos cadenas
    string Concatenar(string a, string b)
    {
        return a + b;
    }

    // 12. Función con parámetro out
    bool TryParseNumero(string texto, out int numero)
    {
        return int.TryParse(texto, out numero);
    }

    // 13. Función que usa params
    int SumarVarios(params int[] numeros)
    {
        int suma = 0;
        foreach (int n in numeros)
            suma += n;
        return suma;
    }

    // 14. Función que retorna un bool si un número es primo
    bool EsPrimo(int numero)
    {
        if (numero < 2) return false;
        for (int i = 2; i <= Math.Sqrt(numero); i++)
            if (numero % i == 0) return false;
        return true;
    }

    // 15. Función genérica
    T RetornarElemento<T>(T valor)
    {
        return valor;
    }

    // 16. Función que convierte Celsius a Fahrenheit
    double CelsiusAFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    // 17. Función que cuenta vocales en una palabra
    int ContarVocales(string palabra)
    {
        int contador = 0;
        foreach (char c in palabra.ToLower())
            if ("aeiou".Contains(c)) contador++;
        return contador;
    }

    // 18. Función que multiplica una lista por un número
    List<int> MultiplicarLista(List<int> numeros, int multiplicador)
    {
        List<int> resultado = new List<int>();
        foreach (int n in numeros)
            resultado.Add(n * multiplicador);
        return resultado;
    }

    // 19. Función que verifica si una palabra es palíndromo
    bool EsPalindromo(string texto)
    {
        string invertido = new string(texto.Reverse().ToArray());
        return texto.Equals(invertido, StringComparison.OrdinalIgnoreCase);
    }

    // 20. Función async simulada (sólo estructura)
    async Task<string> DescargarDatosAsync(string url)
    {
        await Task.Delay(1000); // Simula espera
        return $"Datos descargados desde {url}";
    }
}

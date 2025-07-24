using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Calculadora de Raíz Digital ===");
        Console.WriteLine("Ingrese un número de máximo 8 cifras:");
        
        string? input = Console.ReadLine();
        
        
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Error: Debe ingresar un número válido.");
            return;
        }
        
        // Limpiar espacios en blanco al inicio y final
        input = input.Trim();
        
        // Debug: mostrar la longitud y contenido del input
        Console.WriteLine($"Debug - Input recibido: '{input}', Longitud: {input.Length}");
        
        // Validar que solo contenga dígitos
        if (!EsNumeroValido(input))
        {
            Console.WriteLine("Error: Solo se permiten números enteros positivos.");
            return;
        }
        
        // Validar que tenga máximo 8 cifras
        if (input.Length > 8)
        {
            Console.WriteLine("Error: El número debe tener máximo 8 cifras.");
            return;
        }
        
        int numero = int.Parse(input);
        int resultado = CalcularRaizDigital(numero);
        
        Console.WriteLine($"\nNúmero original: {numero}");
        Console.WriteLine($"Raíz digital: {resultado}");
    }
    
    /// <summary>
    /// Calcula la raíz digital de un número sumando sus dígitos repetidamente hasta obtener un solo dígito
    /// </summary>
    /// <param name="numero">El número del cual calcular la raíz digital</param>
    /// <returns>Un dígito entre 0 y 9</returns>
    static int CalcularRaizDigital(int numero)
    {
        Console.WriteLine("\nProceso de cálculo:");
        Console.WriteLine($"Número inicial: {numero}");
        
        while (numero >= 10)
        {
            int suma = 0;
            int temp = numero;
            
            // Sumar cada dígito
            while (temp > 0)
            {
                suma += temp % 10;
                temp /= 10;
            }
            
            Console.WriteLine($"{numero} → suma de dígitos = {suma}");
            numero = suma;
        }
        
        return numero;
    }
    
    /// <summary>
    /// Valida que la cadena contenga solo dígitos
    /// </summary>
    /// <param name="input">La cadena a validar</param>
    /// <returns>True si solo contiene dígitos, false en caso contrario</returns>
    static bool EsNumeroValido(string input)
    {
        foreach (char c in input)
        {
            if (!char.IsDigit(c))
            {
                return false;
            }
        }
        return true;
    }
}

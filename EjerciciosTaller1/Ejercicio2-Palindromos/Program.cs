using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Verificador de Palíndromos ===");
        Console.WriteLine("Ingrese una cadena para verificar si es palíndromo:");
        
        string? input = Console.ReadLine();
        
        // Validar que el input no esté vacío
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Error: Debe ingresar una cadena válida.");
            return;
        }
        
        bool esPalindromo = EsPalindromo(input);
        
        Console.WriteLine($"\nCadena original: \"{input}\"");
        Console.WriteLine($"¿Es palíndromo? {(esPalindromo ? "SÍ" : "NO")}");
        
        // Mostrar también sin considerar espacios, mayúsculas y caracteres especiales
        bool esPalindromoLimpio = EsPalindromoLimpio(input);
        Console.WriteLine($"¿Es palíndromo (ignorando espacios, mayúsculas y caracteres especiales)? {(esPalindromoLimpio ? "SÍ" : "NO")}");
    }
    
    /// <summary>
    /// Verifica si una cadena es palíndromo (comparación exacta)
    /// </summary>
    /// <param name="texto">La cadena a verificar</param>
    /// <returns>True si es palíndromo, false en caso contrario</returns>
    static bool EsPalindromo(string texto)
    {
        if (string.IsNullOrEmpty(texto))
            return true;
        
        int inicio = 0;
        int fin = texto.Length - 1;
        
        while (inicio < fin)
        {
            if (texto[inicio] != texto[fin])
            {
                return false;
            }
            inicio++;
            fin--;
        }
        
        return true;
    }
    
    /// <summary>
    /// Verifica si una cadena es palíndromo ignorando espacios, mayúsculas y caracteres especiales
    /// </summary>
    /// <param name="texto">La cadena a verificar</param>
    /// <returns>True si es palíndromo, false en caso contrario</returns>
    static bool EsPalindromoLimpio(string texto)
    {
        if (string.IsNullOrEmpty(texto))
            return true;
        
        // Limpiar la cadena: solo letras y números, convertir a minúsculas
        string textoLimpio = "";
        foreach (char c in texto)
        {
            if (char.IsLetterOrDigit(c))
            {
                textoLimpio += char.ToLower(c);
            }
        }
        
        Console.WriteLine($"Cadena limpia para comparar: \"{textoLimpio}\"");
        
        return EsPalindromo(textoLimpio);
    }
}

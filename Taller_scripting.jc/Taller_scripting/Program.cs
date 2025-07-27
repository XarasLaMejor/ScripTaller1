using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== TALLER DE SCRIPTING ===");
        Console.WriteLine("1. Procesamiento de cadena de números");
        Console.WriteLine("2. Procesamiento de matriz");
        Console.Write("Seleccione una opción (1 o 2): ");
        
        string opcion = Console.ReadLine() ?? "";
        
        switch (opcion)
        {
            case "1":
                ProcesarCadenaNumeros();
                break;
            case "2":
                ProcesarMatriz();
                break;
            default:
                Console.WriteLine("Opción no válida. Ejecutando procesamiento de matriz por defecto.");
                ProcesarMatriz();
                break;
        }
        
        Console.WriteLine("\nPresione cualquier tecla para salir...");
        try
        {
            Console.ReadKey();
        }
        catch (InvalidOperationException)
        {
            // Si no se puede leer una tecla (ej: en debugging), usar ReadLine como alternativa
            Console.ReadLine();
        }
    }
    
    static void ProcesarCadenaNumeros()
    {
        Console.WriteLine("\n=== Programa para procesar cadena de números enteros positivos ===");
        
        string cadena = LeerCadenaValida();
        
        if (!string.IsNullOrEmpty(cadena))
        {
            int[] numeros = ConvertirCadenaAArray(cadena);
            MostrarResultados(cadena, numeros);
        }
    }
    
    static void ProcesarMatriz()
    {
        Console.WriteLine("\n=== Procesamiento de Matriz ===");
        
        int[,] matriz = {
            { -1, 2, -3},
            { 6,-8, 9},
            { -3, 4, -5 }
        };

        Console.WriteLine("Matriz original:");
        ImprimirMatriz(matriz);

       
        int filas = matriz.GetLength(0); 
        int columnas = matriz.GetLength(1); 
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                
                if (matriz[i, j] < 0)
                {
                    
                    matriz[i, j] = Math.Abs(matriz[i, j]);
                }
            }
        }

        Console.WriteLine("\nMatriz modificada (negativos reemplazados):");
        ImprimirMatriz(matriz);
    }

    // Función auxiliar para imprimir la matriz en la consola
    static void ImprimirMatriz(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
    
    // === MÉTODOS PARA PROCESAMIENTO DE CADENA DE NÚMEROS ===
    
    /// <summary>
    /// Lee una cadena del usuario y valida que contenga solo números enteros positivos
    /// </summary>
    /// <returns>Cadena válida o cadena vacía si el usuario cancela</returns>
    static string LeerCadenaValida()
    {
        string cadena;
        bool esValida;

        do
        {
            Console.Write("\nIngrese una cadena de números enteros positivos separados por espacios: ");
            cadena = Console.ReadLine() ?? "";

            if (string.IsNullOrWhiteSpace(cadena))
            {
                Console.WriteLine("❌ Error: No puede ingresar una cadena vacía.");
                esValida = false;
                continue;
            }

            esValida = ValidarCadenaNumeros(cadena);

            if (!esValida)
            {
                Console.WriteLine("❌ Error: La cadena debe contener solo números enteros positivos separados por espacios.");
                Console.WriteLine("   Ejemplo válido: '1 2 3 45 67'");

                Console.Write("¿Desea intentar nuevamente? (s/n): ");
                string respuesta = (Console.ReadLine() ?? "").ToLower();

                if (respuesta != "s" && respuesta != "si")
                {
                    return string.Empty;
                }
            }

        }
        while (!esValida);
        
        return cadena.Trim();
    }
    
    /// <summary>
    /// Valida que la cadena contenga solo números enteros positivos
    /// </summary>
    /// <param name="cadena">Cadena a validar</param>
    /// <returns>True si es válida, False en caso contrario</returns>
    static bool ValidarCadenaNumeros(string cadena)
    {
        try
        {
            // Dividir la cadena por espacios y eliminar elementos vacíos
            string[] elementos = cadena.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            if (elementos.Length == 0)
            {
                return false;
            }
            
            // Validar cada elemento
            foreach (string elemento in elementos)
            {
                // Verificar que se puede convertir a entero
                if (!int.TryParse(elemento, out int numero))
                {
                    return false;
                }
                
                // Verificar que sea positivo
                if (numero <= 0)
                {
                    return false;
                }
            }
            
            return true;
        }
        catch
        {
            return false;
        }
    }
    
    /// <summary>
    /// Convierte la cadena validada en un array de enteros
    /// </summary>
    /// <param name="cadena">Cadena de números válida</param>
    /// <returns>Array de enteros</returns>
    static int[] ConvertirCadenaAArray(string cadena)
    {
        try
        {
            string[] elementos = cadena.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numeros = new int[elementos.Length];
            
            for (int i = 0; i < elementos.Length; i++)
            {
                numeros[i] = int.Parse(elementos[i]);
            }
            
            return numeros;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Error al convertir la cadena: {ex.Message}");
            return new int[0];
        }
    }
    
    /// <summary>
    /// Muestra los resultados del procesamiento
    /// </summary>
    /// <param name="cadenaOriginal">Cadena original ingresada</param>
    /// <param name="numeros">Array de números resultante</param>
    static void MostrarResultados(string cadenaOriginal, int[] numeros)
    {
        Console.WriteLine("\n=== RESULTADOS ===");
        Console.WriteLine($"✅ Cadena válida ingresada: \"{cadenaOriginal}\"");
        Console.WriteLine($"📊 Cantidad de números: {numeros.Length}");
        
        Console.WriteLine("\n📋 Array creado:");
        Console.Write("   [");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write(numeros[i]);
            if (i < numeros.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
        
        // Información adicional
        Console.WriteLine("\n📈 Estadísticas:");
        Console.WriteLine($"   • Número mayor: {numeros.Max()}");
        Console.WriteLine($"   • Número menor: {numeros.Min()}");
        Console.WriteLine($"   • Suma total: {numeros.Sum()}");
        Console.WriteLine($"   • Promedio: {numeros.Average():F2}");
    }
}

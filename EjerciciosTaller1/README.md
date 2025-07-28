# Ejercicios de Programación - Scriptaller1

Sahara Alvarez Romero

## Ejercicio 1: Calculadora de Raíz Digital

### ¿Qué hace?
Calcula la raíz digital de un número (suma repetitiva de dígitos hasta obtener un solo dígito).

### Cómo ejecutar:
```bash
cd "Ejercicio1-RaizDigital"
dotnet run
```

### Ejemplo de uso:
- Entrada: `123`
- Proceso: `123 → 1+2+3 = 6`
- Resultado: `6`

- Entrada: `999`
- Proceso: `999 → 9+9+9 = 27 → 2+7 = 9`
- Resultado: `9`

## Ejercicio 2: Verificador de Palíndromos

### ¿Qué hace?
Verifica si una cadena de texto es un palíndromo (se lee igual de izquierda a derecha que de derecha a izquierda).

### Cómo ejecutar:
```bash
cd "Ejercicio2-Palindromos"
dotnet run
```

### Ejemplo de uso:
- Entrada: `oso`
- Resultado: `SÍ es palíndromo`

- Entrada: `A man a plan a canal Panama`
- Resultado: `NO es palíndromo (exacto), SÍ es palíndromo (limpio)`


# Ejercicio 6 - Mariana Echavarria 
"Usando un ciclo do-while calcule la suma de los primeros n números impares."

Suponiendo que el usuario ingresa n = 4, el programa hará lo siguuiente:

numero = 1 → suma = 1

numero = 3 → suma = 4

numero = 5 → suma = 9

numero = 7 → suma = 16

Y muestra:

"La suma de los primeros 4 números impares es: 16"


###  Línea por línea:

---

#### `using System;`

Permite usar funciones básicas del lenguaje como `Console.WriteLine()` y `Console.ReadLine()`.

---

#### `class Program`

Define la clase principal del programa. Todo tu código está dentro de esta clase.

---

#### `static void Main()`

Es el punto de entrada del programa. Aquí empieza a ejecutarse todo.

---

###  Bloque principal

---

#### `Console.Write("Ingrese el valor de n: ");`

 Le muestra un mensaje al usuario pidiéndole que ingrese cuántos números impares quiere sumar.

---

#### `int n = int.Parse(Console.ReadLine());`

 Lee lo que el usuario escribe (por ejemplo, "5") y lo convierte a un número entero (`int`).

---

#### `int suma = 0;`

 Inicializa la variable `suma` que va a acumular el resultado de la suma.

---

#### `int contador = 0;`

 Cuenta cuántos números impares has sumado hasta el momento. Se usa para saber cuándo parar.

---

#### `int numero = 1;`

 Es el primer número impar. Comienzas en 1, luego irá a 3, luego 5, etc.

---

###  Bloque `do-while`

```csharp
do
{
    suma += numero;
    contador++;
    numero += 2;
} while (contador < n);
```

---

1. **`suma += numero;`**
    Suma el número impar actual a la variable `suma`.

2. **`contador++;`**
   Aumenta en 1 el número de impares sumados.

3. **`numero += 2;`**
   Pasa al siguiente número impar (1 → 3 → 5 → ...).

4. **`while (contador < n);`**
   Se repite hasta que hayas sumado `n` números impares.

---

###  Resultado final

```csharp
Console.WriteLine($"La suma de los primeros {n} números impares es: {suma}");
```

 Muestra la suma total en pantalla. Por ejemplo, si `n = 3`:

* 1 + 3 + 5 = **9**
* Salida: **La suma de los primeros 3 números impares es: 9**

---


| Nº | Firma de la Función                                                | Descripción                                         | ¿Para qué sirve?                                            |
| -- | ------------------------------------------------------------------ | --------------------------------------------------- | ----------------------------------------------------------- |
| 1  | `static void ImprimirDatos(string nombre, int edad = 18)`          | Parámetro con valor por defecto                     | Muestra nombre y edad, incluso si no se proporciona la edad |
| 2  | `void MostrarBienvenida()`                                         | Sin parámetros ni retorno                           | Muestra un mensaje de bienvenida                            |
| 3  | `double CalcularPromedio(int a, int b)`                            | Recibe dos enteros y retorna un `double`            | Calcula el promedio entre dos números                       |
| 4  | `DateTime ObtenerFechaActual()`                                    | Sin parámetros, retorna `DateTime`                  | Devuelve la fecha y hora actual                             |
| 5  | `int ContarCaracteres(string texto)`                               | Recibe una cadena y retorna su longitud             | Cuenta la cantidad de caracteres                            |
| 6  | `bool EsPar(int numero)`                                           | Evalúa si un número es par                          | Retorna `true` si el número es par                          |
| 7  | `static void Incrementar(ref int valor)`                           | Usa `ref` para modificar un valor desde el exterior | Incrementa el valor de una variable                         |
| 8  | `void ImprimirLista(List<string> elementos)`                       | Recibe una lista y no retorna nada                  | Muestra cada elemento de la lista                           |
| 9  | `int Factorial(int n)`                                             | Función recursiva                                   | Calcula el factorial de un número                           |
| 10 | `int Maximo(int a, int b)`                                         | Retorna el mayor de dos números                     | Compara y devuelve el más grande                            |
| 11 | `string Concatenar(string a, string b)`                            | Une dos cadenas de texto                            | Devuelve una cadena concatenada                             |
| 12 | `bool TryParseNumero(string texto, out int numero)`                | Usa `out` para intentar convertir texto a número    | Intenta convertir string a int                              |
| 13 | `int SumarVarios(params int[] numeros)`                            | Usa `params` para recibir múltiples argumentos      | Suma todos los números dados                                |
| 14 | `bool EsPrimo(int numero)`                                         | Evalúa si un número es primo                        | Retorna `true` si es primo                                  |
| 15 | `T RetornarElemento<T>(T valor)`                                   | Función genérica                                    | Devuelve cualquier tipo de dato que se le pase              |
| 16 | `double CelsiusAFahrenheit(double celsius)`                        | Conversión matemática                               | Convierte de grados Celsius a Fahrenheit                    |
| 17 | `int ContarVocales(string palabra)`                                | Recorre la cadena                                   | Cuenta cuántas vocales hay en una palabra                   |
| 18 | `List<int> MultiplicarLista(List<int> numeros, int multiplicador)` | Opera sobre una lista de enteros                    | Devuelve una nueva lista con los elementos multiplicados    |
| 19 | `bool EsPalindromo(string texto)`                                  | Verifica palíndromos                                | Retorna `true` si la palabra se lee igual al revés          |
| 20 | `async Task<string> DescargarDatosAsync(string url)`               | Función `async`                                     | Simula una descarga de datos asíncrona                      |








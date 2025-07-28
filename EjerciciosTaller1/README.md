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

 Usa do-while correctamente
 Controla cuántos impares se han sumado con contador
 Suma correctamente los impares (1, 3, 5...)
 Pide al usuario el valor de n
 Imprime un mensaje claro al final

 ¿Qué hace el código?
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
   ➤Aumenta en 1 el número de impares sumados.

3. **`numero += 2;`**
   ➤Pasa al siguiente número impar (1 → 3 → 5 → ...).

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








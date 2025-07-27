# Programa de Procesamiento de Cadena de Números Enteros Positivos

## Descripción
Este programa lee una cadena de números enteros positivos, valida que contenga solo números válidos, y crea un array con esos números.

## Funcionalidades Implementadas

### 1. Validación de Entrada
- ✅ Verifica que la cadena no esté vacía
- ✅ Valida que todos los elementos sean números enteros
- ✅ Confirma que todos los números sean positivos (> 0)
- ✅ Maneja espacios múltiples entre números
- ✅ Permite al usuario reintentar si la entrada es inválida

### 2. Procesamiento
- ✅ Convierte la cadena validada en un array de enteros
- ✅ Maneja errores durante la conversión
- ✅ Proporciona retroalimentación detallada

### 3. Resultados
- ✅ Muestra la cadena original ingresada
- ✅ Despliega el array creado
- ✅ Proporciona estadísticas: mayor, menor, suma, promedio
- ✅ Cuenta la cantidad de números procesados

## Casos de Uso Válidos
```
Entrada: "1 2 3 4 5"
Array resultante: [1, 2, 3, 4, 5]

Entrada: "10 20 30"
Array resultante: [10, 20, 30]

Entrada: "123 456 789"
Array resultante: [123, 456, 789]
```

## Casos Inválidos (Rechazados)
```
"1 2 -3 4"      → Contiene número negativo
"1 2 abc 4"     → Contiene texto no numérico
"1 2 0 4"       → Contiene cero (no es positivo)
"1,2,3"         → Separador incorrecto
""              → Cadena vacía
```

## Cómo Usar
1. Ejecutar el programa: `dotnet run`
2. Seleccionar opción 1 (Procesamiento de cadena de números)
3. Ingresar una cadena de números enteros positivos separados por espacios
4. El programa validará la entrada y mostrará los resultados

## Estructura del Código
- `LeerCadenaValida()`: Lee y valida la entrada del usuario
- `ValidarCadenaNumeros()`: Verifica que la cadena contenga solo números positivos
- `ConvertirCadenaAArray()`: Convierte la cadena en array de enteros
- `MostrarResultados()`: Presenta los resultados con estadísticas

## Tecnologías Utilizadas
- C# (.NET 9.0)
- System.Linq para estadísticas (Max, Min, Sum, Average)
- Manejo de excepciones para robustez

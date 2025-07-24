# Ejercicios de Programación - Scriptaller1

Esta carpeta contiene dos ejercicios de programación en C# para el repositorio Scriptaller1.

## Estructura del Proyecto

```
Ejercicios/
├── Ejercicio1-RaizDigital/     # Calculadora de Raíz Digital
│   ├── Program.cs
│   └── Ejercicio1-RaizDigital.csproj
├── Ejercicio2-Palindromos/     # Verificador de Palíndromos
│   ├── Program.cs
│   └── Ejercicio2-Palindromos.csproj
├── .gitignore                  # Archivos ignorados por Git
├── setup-git.bat              # Script para configurar Git
└── README.md                   # Este archivo
```

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

## Configuración del Repositorio Git

### Prerequisitos
1. Instalar Git desde: https://git-scm.com/download/win
2. Crear un repositorio en GitHub llamado "Scriptaller1"

### Pasos para subir al repositorio:

#### Opción 1: Usar el script automático
1. Ejecutar `setup-git.bat`
2. Seguir las instrucciones en pantalla

#### Opción 2: Comandos manuales
```bash
# 1. Inicializar repositorio
git init

# 2. Agregar archivos
git add .

# 3. Commit inicial
git commit -m "Primer commit: Ejercicios de Raiz Digital y Palindromos"

# 4. Conectar con GitHub (reemplaza 'tu-usuario' con tu nombre de usuario)
git remote add origin https://github.com/tu-usuario/Scriptaller1.git

# 5. Subir al repositorio
git branch -M main
git push -u origin main
```

## Requisitos
- .NET 9.0 o superior
- Git (para control de versiones)
- Sistema operativo: Windows, macOS, o Linux

## Notas
- Ambos programas incluyen validación de entrada
- El verificador de palíndromos ofrece dos modos: exacto y limpio (ignora espacios, mayúsculas y caracteres especiales)
- El archivo .gitignore está configurado para proyectos .NET

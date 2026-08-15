# 📚 Sistema de Gestión de Biblioteca (C#)

Un sistema de gestión de biblioteca basado en la consola de comandos (CLI) construido con **C# y .NET 10**. Este proyecto fue desarrollado como parte del reto de aprendizaje continuo ("C# Hero Roadmap 56 Days" - Semana 2, Día 14) para consolidar conceptos de Programación Orientada a Objetos (POO).

## 🚀 Características
- **Listar Libros:** Visualiza todo el catálogo de la biblioteca junto con su estado de disponibilidad y detalles de publicación.
- **Añadir Libro:** Ingresa el título, autor y año de publicación para agregar nuevos libros al sistema.
- **Eliminar Libro:** Elimina libros del registro utilizando su ID único.
- **Prestar Libro:** Busca un libro y, si está disponible, márcalo como "prestado".
- **Devolver Libro:** Marca un libro prestado como "disponible" nuevamente en el inventario.

## 🛠️ Tecnologías Utilizadas
- **Lenguaje:** C#
- **Framework:** .NET 10.0
- **Paradigma:** Programación Orientada a Objetos (POO)

## 📂 Estructura del Código
- `Program.cs`: Maneja el ciclo principal de la interfaz de usuario, limpiando la consola y procesando las entradas del menú mediante estructuras `switch`.
- `Library.cs`: Gestiona los menús y actúa como puente para las interacciones del usuario de préstamos y devoluciones.
- `Book.cs`: La clase principal que define las propiedades del libro (Título, Autor, Año, Estado), y gestiona la lógica de la lista genérica `List<Book>` para almacenar los registros de manera persistente durante la ejecución.

## ⚙️ Cómo Ejecutar el Proyecto
Asegúrate de tener instalado el [SDK de .NET 10](https://dotnet.microsoft.com/download).

1. Clona este repositorio o descarga el código fuente.
2. Abre una terminal (o consola de comandos) y navega hasta la carpeta raíz del proyecto (donde se encuentra el archivo `LibrarySystem.csproj`).
3. Ejecuta el siguiente comando para compilar y lanzar la aplicación:
   ```bash
   dotnet run
   ```

## 🧠 Aprendizajes Destacados
- Uso de `List<T>` para almacenamiento en memoria.
- Auto-properties y manejo de estado de objetos (`Available`).
- Interacción de menús en consola limpia usando `Console.Clear()` y `Console.ReadLine()`.
- Lógica de validación para evitar modificaciones concurrentes en bucles `foreach`.
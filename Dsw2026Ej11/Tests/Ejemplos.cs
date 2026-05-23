using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;

internal class Ejemplos
{
    public static void EjemploList()
    {
        Console.WriteLine("--- EJEMPLO LIST ---");
        CasoList casoList = new CasoList();

        // Agregar 3 alumnos a la lista
        Alumno a1 = new Alumno(101, "Carlos", 8.5);
        Alumno a2 = new Alumno(102, "Natalia", 9.0);
        Alumno a3 = new Alumno(103, "Roberto", 7.5);

        casoList.AgregarAlumno(a1);
        casoList.AgregarAlumno(a2);
        casoList.AgregarAlumno(a3);

        // Listar por consola los alumnos
        Console.WriteLine("Lista original:");
        foreach (var a in casoList.ObtenerLista()) Console.WriteLine(a.Nombre);

        // Buscar por nombre un alumno que exista y mostrar por consola
        var encontrado = casoList.BuscarPorNombre("Natalia");
        Console.WriteLine("\nBuscando a Natalia: " + (encontrado != null ? encontrado.Nombre : "No existe"));

        // Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
        var noEncontrado = casoList.BuscarPorNombre("Pedro");
        Console.WriteLine("Buscando a Pedro: " + (noEncontrado != null ? noEncontrado.Nombre : "No existe"));

        // Eliminar un alumno y listar por consola los alumnos
        Console.WriteLine("\nEliminando a Roberto...");
        casoList.EliminarAlumno(a3);
        foreach (var a in casoList.ObtenerLista()) Console.WriteLine(a.Nombre);

        // Eliminar el primer elemento de la lista y listar por consola los alumnos
        Console.WriteLine("\nEliminando el primer elemento...");
        casoList.EliminarAlumnoEnPosicion(0);
        foreach (var a in casoList.ObtenerLista()) Console.WriteLine(a.Nombre);
        Console.WriteLine("--------------------\n");
    }

    public static void EjemploDictionary()
    {
        Console.WriteLine("--- EJEMPLO DICTIONARY ---");
        CasoDictionary casoDict = new CasoDictionary();
     
        Alumno a1 = new Alumno(101, "Carlos", 8.5);
        Alumno a2 = new Alumno(102, "Natalia", 9.0);
        Alumno a3 = new Alumno(103, "Roberto", 7.5);

        // Agregar 3 alumnos al diccionario
        casoDict.AgregarAlumno(101, a1);
        casoDict.AgregarAlumno(102, a2);
        casoDict.AgregarAlumno(103, a3);

        // Listar por consola los alumnos
        Console.WriteLine("Diccionario original:");
        foreach (var item in casoDict.ObtenerDiccionario())
        {
            Console.WriteLine($"Legajo: {item.Key} - Nombre: {item.Value.Nombre}");
        }

        // Buscar un alumno por clave y mostrar por consola
        var encontrado = casoDict.BuscarPorClave(102);
        Console.WriteLine("\nBuscando legajo 102: " + (encontrado != null ? encontrado.Nombre : "No existe"));

        // Buscar un alumno por clave, pero que no exista...
        var noEncontrado = casoDict.BuscarPorClave(999);
        Console.WriteLine("Buscando legajo 999: " + (noEncontrado != null ? noEncontrado.Nombre : "No existe"));

        // Eliminar un alumno por clave y listar por consola los alumnos
        Console.WriteLine("\nEliminando legajo 103...");
        casoDict.EliminarAlumno(103);
        foreach (var item in casoDict.ObtenerDiccionario())
        {
            Console.WriteLine($"Legajo: {item.Key} - Nombre: {item.Value.Nombre}");
        }
        Console.WriteLine("--------------------\n");
    }
    
    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        Console.WriteLine("--- EJEMPLO LINQ ---");
        CasoLinq casoLinq = new CasoLinq();

        // Aprovechamos el método del profe para cargar la lista de prueba
        var libros = Libro.CrearLista();

        // Realizar una llamada a cada método y mostrar por consola
        Console.WriteLine("1. Primer libro: " + casoLinq.GetPrimero(libros)?.Titulo);
        Console.WriteLine("2. Último libro: " + casoLinq.GetUltimo(libros)?.Titulo);

        // El :C en el string transforma el número a formato moneda
        Console.WriteLine($"3. Total de precios: {casoLinq.GetTotalPrecios(libros):C}");
        Console.WriteLine($"4. Promedio de precios: {casoLinq.GetPromedioPrecios(libros):C}");

        Console.WriteLine("\n5. Libros con ID > 15:");
        foreach (var l in casoLinq.GetListById(libros)) Console.WriteLine($"- {l.Titulo}");

        Console.WriteLine("\n6. Título y Precio formato moneda:");
        foreach (var l in casoLinq.GetLibros(libros)) Console.WriteLine($"- {l}");

        Console.WriteLine("\n7. Mayor precio: " + casoLinq.GetMayorPrecio(libros)?.Titulo);
        Console.WriteLine("8. Menor precio: " + casoLinq.GetMenorPrecio(libros)?.Titulo);

        Console.WriteLine("\n9. Libros con precio mayor al promedio:");
        foreach (var l in casoLinq.GetMayorPromedio(libros)) Console.WriteLine($"- {l.Titulo}");

        Console.WriteLine("\n10. Libros ordenados descendente:");
        foreach (var l in casoLinq.GetLibrosOrdenados(libros)) Console.WriteLine($"- {l.Titulo}");
        Console.WriteLine("--------------------\n");
    }
}
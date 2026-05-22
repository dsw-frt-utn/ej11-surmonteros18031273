//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista

using Dsw2026Ej11.Domain; // Agregamos esto arriba para que reconozca la clase Alumno
using System.Collections.Generic;
using System.Linq;

namespace Dsw2026Ej11.Collections;

public class CasoList
{
    // Crear un campo que represente una lista de alumnos (List<>)
    private List<Alumno> listaAlumnos = new List<Alumno>();

    // Incluir un método para agregar alumnos a la lista
    public void AgregarAlumno(Alumno alumno)
    {
        listaAlumnos.Add(alumno);
    }

    // Incluir un método para retornar la lista
    public List<Alumno> ObtenerLista()
    {
        return listaAlumnos;
    }

    // Incluir un método para buscar un alumno por nombre
    
    public Alumno? BuscarPorNombre(string nombre)
    {
        // Uso una expresión lambda para buscar el primero que coincida
        return listaAlumnos.Find(a => a?.Nombre == nombre);
    }

    // Incluir un método para eliminar un alumno (debe recibir un alumno)
    public void EliminarAlumno(Alumno alumno)
    {
        listaAlumnos.Remove(alumno);
    }

    // Incluir un método para eliminar un alumno en una determinada posición de la lista
    public void EliminarAlumnoEnPosicion(int posicion)
    {
        // Valido que la posición exista para que no tire error
        if (posicion >= 0 && posicion < listaAlumnos.Count)
        {
            listaAlumnos.RemoveAt(posicion);
        }
    }
}
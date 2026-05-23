//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

public class CasoDictionary
{
    // Crear un diccionario donde la clave sea el legajo y el valor el alumno
    // Nota: Asumo que el legajo es un número entero (int). Si en tu clase Alumno es un string, cambialo.
    private Dictionary<int, Alumno> diccionarioAlumnos = new Dictionary<int, Alumno>();

    // Incluir un método para agregar un alumno al diccionario
    public void AgregarAlumno(int legajo, Alumno alumno)
    {
        // TryAdd es genial porque si por error intentás agregar un legajo que ya existe, no hace explotar el programa.
        diccionarioAlumnos.TryAdd(legajo, alumno);
    }

    // Incluir un método para buscar un alumno utilizando la clave
    public Alumno? BuscarPorClave(int legajo)
    {
        // TryGetValue busca la clave. Si la encuentra, devuelve el alumno. Si no, devuelve nulo de forma segura.
        if (diccionarioAlumnos.TryGetValue(legajo, out Alumno? alumnoEncontrado))
        {
            return alumnoEncontrado;
        }
        return null;
    }

    // Incluir un método para retornar el diccionario
    public Dictionary<int, Alumno> ObtenerDiccionario()
    {
        return diccionarioAlumnos;
    }

    // Incluir un método para eliminar un alumno utilizando la clave
    public void EliminarAlumno(int legajo)
    {
        diccionarioAlumnos.Remove(legajo);
    }
}

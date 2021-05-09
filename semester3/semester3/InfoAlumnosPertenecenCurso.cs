using System;
using System.Collections.Generic;

namespace semester3
{
    public class InfoAlumnosPertenecenCurso
    {
        public static void InfoAlumnoPorCurso(List<Alumno> listaAlumnos)
        {
            Console.Clear();
            Console.WriteLine("Introduce codigo curso");
            string codeCurso = Console.ReadLine();
            for (int i = 0; i < listaAlumnos.Count; i++)
            {
                if (codeCurso == listaAlumnos[i].GetCodeCurso())
                {
                    
                    Console.WriteLine("El nombre del alumno {0}", listaAlumnos[i].GetNameAlumno());
                    Console.WriteLine("El DNI del alumno {0}", listaAlumnos[i].GetDniAlumno());
                    Console.WriteLine(" ");
                }
                
            }
        }
    }
}
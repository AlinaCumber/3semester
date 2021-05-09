using System;
using System.Collections.Generic;

namespace semester3
{
    public class FuncionCurso
    {
        public static void CreateCurso(List<Curso> listaCursos)
        {
            Curso curso = new Curso();
            Console.WriteLine("Introduce el nombre del curso");
            curso.SetNameCurso(Console.ReadLine());
            Console.WriteLine("Introduce el codigo del curso");
            curso.SetCodeCurso(Console.ReadLine());
            listaCursos.Add(curso);
        }

        public static void ImprimirListaCursos(List<Curso> listaCursos)
        {
            for (int i = 0; i < listaCursos.Count; i++)
            {
                listaCursos[i].ImprimirInfoCurso();
            }
        }

        public static void DeleteCurso(List<Curso> listaCursos)
        {
            Console.WriteLine("Para borrar el curso introduce su codigo");
            string delete = Console.ReadLine();
            for (int i = 0; i < listaCursos.Count; i++)
            {
                if (delete == listaCursos[i].GetCodeCurso())
                {
                    listaCursos.Remove(listaCursos[i]);
                }
            }
        }


    }
}
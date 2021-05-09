using System;
using System.Collections.Generic;

namespace semester3
{
    public class Alumno
    {
        private string nameAlumno;
        private string DniAlumno;
        private List<double> notas;
        private string codeCurso;


        public Alumno(string nameAlumno, string dniAlumno, List<double> notas, string codeCurso)
        {
            this.nameAlumno = nameAlumno;
            DniAlumno = dniAlumno;
            this.notas = notas;
            this.codeCurso = codeCurso;
        }

        public Alumno(string nameAlumno, string dniAlumno, string codeCurso)
        {
            this.nameAlumno = nameAlumno;
            DniAlumno = dniAlumno;
            this.codeCurso = codeCurso;
        }

        public Alumno()
        {
            
        }

        public void SetNameAlumno(string nameAlumno)
        {
            this.nameAlumno = nameAlumno;
        }

        public string GetNameAlumno()
        {
            return nameAlumno;
        }

        public void SetDniAlumno(string DniAlumno)
        {
            this.DniAlumno = DniAlumno;
        }

        public string GetDniAlumno()
        {
            return DniAlumno;
        }

        public List<double> GetListNotas()
        {
            return notas;
        }


        public void SetNotas(List<double> notas)
        {
            this.notas = notas;
            Console.WriteLine("Introduce nota del 1 trimestre");
            double nota = Convert.ToDouble(Console.ReadLine());
            notas.Add(nota);

            Console.WriteLine("Introduce nota del 2 trimestre");
            nota = Convert.ToDouble(Console.ReadLine());
            notas.Add(nota);

            Console.WriteLine("Introduce nota del 3 trimestre");
            nota = Convert.ToDouble(Console.ReadLine());
            notas.Add(nota);
        }

        public List<double> GetNotas()
        {
            return notas;
        }


        public void BorraNotas()
        {
            if (notas.Count == 0)
                Console.WriteLine("No existen notas para los alumnos");
            else
            {
                for (int i = 0; i < notas.Count;)
                {
                    notas.RemoveAt(i);
                    if (notas.Count == 0)
                    {
                        break;
                    }
                }
            }
        }

        

        public void SetCodeCurso(string codeCurso)
        {
            this.codeCurso = codeCurso;
        }

        public string GetCodeCurso()
        {
            return codeCurso;
        }

        public void InfoAlumno(List<Alumno> listaAlumnos)
        {
            Console.WriteLine("Nombre del Alumno {0}", nameAlumno);
            Console.WriteLine("DNI del Alumno {0}", DniAlumno);
            Console.WriteLine("Esta matriculado en {0}", codeCurso);
           
            if (notas == null)
            {
                Console.WriteLine();
            }

            else if (notas.Count > 0)
            {
                for (int i = 0; i < notas.Count; i++)
                {
                    Console.WriteLine("La nota de {0} trimestre es " + notas[i], i + 1);
                }
            }

            Console.WriteLine(" ");
        }

        public static void OrdenarListaAlumnos(List<Alumno> listaAlumnos)
        {
            for (int i = 0; i < listaAlumnos.Count - 1; i++)
            {
                for (int j = i + 1; j < listaAlumnos.Count; j++)
                {
                    string el1 = listaAlumnos[i].nameAlumno;
                    string el2 = listaAlumnos[j].nameAlumno;
                    if (String.Compare(el1, el2, StringComparison.Ordinal) > 0)
                    {
                        string aux = el1;
                        listaAlumnos[i].nameAlumno = listaAlumnos[j].nameAlumno;
                        listaAlumnos[j].nameAlumno = aux;
                    }
                }
            }

            for (int i = 0; i < listaAlumnos.Count; i++)
            {
                listaAlumnos[i].InfoAlumno(listaAlumnos);
            }
        }
    }
}
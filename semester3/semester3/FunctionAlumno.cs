using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace semester3
{
    public class FunctionAlumno
    {
        public static void CreateAlumno(List<Alumno> listaAlumnos, List<Curso> listaCursos)
        {
            Alumno alumno = new Alumno();
            string name = VerifyValues.VerifyName();
            alumno.SetNameAlumno(name);
            string dni = VerifyValues.VerifyDni();
            alumno.SetDniAlumno(dni);
            string codigo = VerifyValues.VerifyCurso(listaCursos);
            alumno.SetCodeCurso(codigo);
            listaAlumnos.Add(alumno);
        }

        public static void ImprimirListaAlumnos(List<Alumno> listaAlumnos)
        {
            for (int i = 0; i < listaAlumnos.Count; i++)
            {
                if (listaAlumnos.Count == 0)
                {
                    Console.WriteLine("Mo hay ningun alumno registado");
                }
                else
                {
                    listaAlumnos[i].InfoAlumno(listaAlumnos);
                }
            }
        }

        public static void ImprimirInfoAlumno(List<Alumno> listaAlumnos)
        {
            inicio:
            Console.WriteLine("Introduce nombre para mostrar la informacon del alumno");
            string nombre = Console.ReadLine();
            for (int i = 0; i < listaAlumnos.Count; i++)
            {
                if (nombre == listaAlumnos[i].GetNameAlumno())
                {
                    listaAlumnos[i].InfoAlumno(listaAlumnos);
                    break;
                }
                else if (nombre != listaAlumnos[i].GetDniAlumno())
                {
                    Console.WriteLine("DNI mal introducido");
                    goto inicio;
                }
            }
        }


        public static void DeleteAlumno(List<Alumno> listaAlumnos)
        {
            inicio:
            Console.WriteLine("Para borrar el alumno introduce su DNI");
            string delete = Console.ReadLine();
            for (int i = 0; i < listaAlumnos.Count; i++)
            {
                if (delete == listaAlumnos[i].GetDniAlumno())
                {
                    listaAlumnos.Remove(listaAlumnos[i]);
                    Console.WriteLine("Alumno borrado");
                    break;
                }

                else if (delete != listaAlumnos[i].GetDniAlumno())
                {
                    Console.WriteLine("DNI mal introducido");
                    goto inicio;
                }
            }
        }

        public static void IntroducirNotasAlumno(List<Alumno> listaAlumnos)
        {
            inicio:
            Console.WriteLine("Introduce nombre del alumno para anadir notas");
            string nombre = Console.ReadLine();
            for (int i = 0; i < listaAlumnos.Count; i++)
            {
                if (nombre == listaAlumnos[i].GetNameAlumno())
                {
                    listaAlumnos[i].SetNotas(new List<double>());
                    break;
                }

                else if (nombre != listaAlumnos[i].GetNameAlumno())
                {
                    Console.WriteLine("Nombre mal introducido");
                    goto inicio;
                }
            }
        }


        public static void notaMediaMayorCinco(List<Alumno> listaAlumnos)
        {
            double nota = 0;
            double sum = 0;

            for (int i = 0; i < listaAlumnos.Count; i++)
            {
                if (listaAlumnos[i].GetListNotas() == null)
                {
                    continue;
                }

                List<double> notas = listaAlumnos[i].GetListNotas();


                for (int j = 0; j < notas.Count; j++)
                {
                    double nota1 = notas[j];
                    sum = sum + nota1;
                }

                nota = sum / 3;
                if (nota >= 5)
                {
                    Console.WriteLine("Nombre del Alumno {0}", listaAlumnos[i].GetNameAlumno());
                    Console.WriteLine("");
                }

                sum = 0;
            }
        }

        public static void notaMediaMenorCinco(List<Alumno> listaAlumnos)
        {
            double nota = 0;
            double sum = 0;

            for (int i = 0; i < listaAlumnos.Count; i++)
            {
                if (listaAlumnos[i].GetListNotas() == null)
                {
                    continue;
                }

                List<double> notas = listaAlumnos[i].GetListNotas();


                for (int j = 0; j < notas.Count; j++)
                {
                    double nota1 = notas[j];
                    sum = sum + nota1;
                }

                nota = sum / 3;
                if (nota < 5)
                {
                    Console.WriteLine("Nombre del Alumno {0}", listaAlumnos[i].GetNameAlumno());
                    Console.WriteLine("");
                }

                sum = 0;
            }
        }

        public static void DeleteNotas(List<Alumno> listaAlumnos)
        {
           
            Console.WriteLine("Introduce nombre del alumno para borrarle");
            string name = Console.ReadLine();
            for (int i = 0; i < listaAlumnos.Count; i++)
            {
                if (name == listaAlumnos[i].GetNameAlumno())
                {
                    listaAlumnos[i].BorraNotas();
                    Console.WriteLine("Notas borradas correctamente");
                    break;
                }

                
            }
        }
    }
}
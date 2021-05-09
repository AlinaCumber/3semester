using System;
using System.Collections.Generic;


namespace semester3
{
    public class FunctionProfesor
    {
        public static void CreateProfesor(List<Profesor> listaProfesores)
        {
            Profesor profe = new Profesor();
            string name = VerifyValues.VerifyName();
            profe.SetNameProfesor(name);
            string dni = VerifyValues.VerifyDni();
            profe.SetDniProfesor(dni);
            listaProfesores.Add(profe);
        }

        public static void ImprimirListaProfesor(List<Profesor> listaProfesores)
        {
            Console.Clear();
            for (int i = 0; i < listaProfesores.Count; i++)
            {
                if (listaProfesores.Count == 0)
                {
                    Console.WriteLine("No hay profesores registrados");
                    break;
                }
                else
                {
                    listaProfesores[i].InfoProfesor(listaProfesores);
                }
            }
        }

        public static void ImprimirInfoProfesor(List<Profesor> listaProfesores)
        {
            inicio:
            Console.Clear();
            Console.WriteLine("Introduce nombre");
            string nombre = Console.ReadLine();
            for (int i = 0; i < listaProfesores.Count; i++)
            {
                if (nombre == listaProfesores[i].GetNameProfesor())
                {
                    listaProfesores[i].InfoProfesor(listaProfesores);
                    break;
                }
                else if (nombre != listaProfesores[i].GetNameProfesor())
                {
                    Console.WriteLine("Nombre mal introducido");
                    goto inicio;
                }
 
            }
        }

        public static void DeleteProgesor(List<Profesor> listaProfesores)
        {
            inicio:
            Console.Clear();
            Console.WriteLine("Para borrar el profesor introduce su DNI");
            string delete = Console.ReadLine();
            for (int i = 0; i < listaProfesores.Count; i++)
            {
                if (delete == listaProfesores[i].GetDniProfesor())
                {
                    listaProfesores.Remove(listaProfesores[i]);
                }
                else if (delete != listaProfesores[i].GetDniProfesor())
                {
                    Console.WriteLine("Dni mal introducido");
                    goto inicio;
                }
            }
        }

        public static void IntroducirAsignaturasProfesor(List<Profesor> listaProfesores, List<Curso> listaCursos)
        {
            Console.Clear();
            Console.WriteLine("Introduce nombre del profesor para anadir asignaturas");
            string nombre = Console.ReadLine();
            for (int i = 0; i < listaProfesores.Count; i++)
            {
                if (nombre == listaProfesores[i].GetNameProfesor())
                {
                    listaProfesores[i].SetAsignaturas(new List<string>(), listaProfesores, listaCursos);
                }
            }
        }

        public static void BorrarAsignaturaDelProfe(List<Profesor> listaProfesores)
        {
            inicio:
            Console.Clear();
            Console.WriteLine("Introduce nombre del profesor");
            string nombre = Console.ReadLine();
            for (int i = 0; i < listaProfesores.Count; i++)
            {
                if (nombre == listaProfesores[i].GetNameProfesor())
                {
                    Console.WriteLine("Introduce asignatura que quiere borrar");
                    string nombreAsignatura = Console.ReadLine();
                    listaProfesores[i].BorrarUnaAsignatura(nombreAsignatura);
                    
                }
                else if(nombre != listaProfesores[i].GetNameProfesor())
                {
                    Console.WriteLine("Habies introducido mal el nombre del profesor");
                    goto inicio;
                }
            }
        }

        public static void ProfesQueRepartenAsinatura(List<Profesor> listaProfesores)
        {
            Console.WriteLine("Introduce asignatura");
            string asignatura = Console.ReadLine();
            for (int i = 0; i < listaProfesores.Count; i++)
            {
                if (listaProfesores[i].GetListAsignaturas() == null)
                {
                    continue;
                }
                List<string> asignaturaList = listaProfesores[i].GetListAsignaturas();
                for (int j = 0; j < asignaturaList.Count; j++)
                {
                    if (asignatura == asignaturaList[j])
                    {
                        Console.WriteLine( listaProfesores[i].GetNameProfesor());
                        
                    }
                    
                   
                }
                
            }
        }
        
        
    }
}
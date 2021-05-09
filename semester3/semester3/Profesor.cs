using System;
using System.Collections.Generic;

namespace semester3
{
    public class Profesor
    {
        private string nameProfesor;
        private string DniProfesor;
        private List<string> asignaturas;
       

        public Profesor(string nameProfesor, string dniProfesor, List<string> asignaturas)
        {
            this.nameProfesor = nameProfesor;
            DniProfesor = dniProfesor;
            this.asignaturas = asignaturas;
           
        }


        public Profesor(string nameProfesor, string dniProfesor)
        {
            this.nameProfesor = nameProfesor;
            DniProfesor = dniProfesor;
            
        }

        public Profesor()
        {
            
        }

        public void SetNameProfesor(string nameProfesor)
        {
            this.nameProfesor = nameProfesor;
        }

        public string GetNameProfesor()
        {
            return nameProfesor;
        }

        public void SetDniProfesor(string DniProfesor)
        {
            this.DniProfesor = DniProfesor;
        }

        public string GetDniProfesor()
        {
            return DniProfesor;
        }

        public List<string> GetListAsignaturas()
        {
            return asignaturas;
        }


        public void SetAsignaturas(List<string> asignaturas, List<Profesor> listaProfesores, List<Curso>listaCursos)
        {
            this.asignaturas = asignaturas;
            string prompt = "Asignaturas profesor";
            string[] options =
            {
                "Anadir asignatura al profesor", "Codigo curso si es tutor", "Salir"
            };
            MenuApp menuCurso = new MenuApp(prompt, options);
            int selectedIndex = menuCurso.Run();

            switch (selectedIndex)
            {
                case 0:
                    Console.WriteLine("Escribe asignatura que reparta el profesor");
                    string asignatura = Console.ReadLine();
                    asignaturas.Add(asignatura);
                    SetAsignaturas(asignaturas, listaProfesores, listaCursos);
                    break;
                case 1:
                    Console.WriteLine("Escribe el codigo de curso de cual es tutor");
                    string codigo = VerifyValues.VerifyCurso(listaCursos);
                    asignaturas.Add(codigo);
                        
                    
                    
                    SetAsignaturas(asignaturas, listaProfesores, listaCursos);
                    break;
                case 2:
                    AppCursos.GestionProfesores(listaProfesores);
                    break;
            }
        }

        public void InfoProfesor(List<Profesor> listaProfesor)
        {
            Console.WriteLine("Nombre del Profesor {0}", nameProfesor);
            Console.WriteLine("DNI del Profesor {0}", DniProfesor);
            


            if (asignaturas == null)
            {
            }

            else if (asignaturas.Count > 0)
            {
                for (int i = 0; i < asignaturas.Count; i++)
                {
                    Console.WriteLine(asignaturas[i]);
                }
                
            }

            Console.WriteLine(" ");
        }

        public static void OrdenarListaProfesores(List<Profesor> listaProfesor)
        {
            for (int i = 0; i < listaProfesor.Count - 1; i++)
            {
                for (int j = i + 1; j < listaProfesor.Count; j++)
                {
                    string el1 = listaProfesor[i].nameProfesor;
                    string el2 = listaProfesor[j].nameProfesor;
                    if (String.Compare(el1, el2, StringComparison.Ordinal) > 0)
                    {
                        string aux = el1;
                        listaProfesor[i].nameProfesor = listaProfesor[j].nameProfesor;
                        listaProfesor[j].nameProfesor = aux;
                    }
                }
            }

            for (int i = 0; i < listaProfesor.Count; i++)
            {
                listaProfesor[i].InfoProfesor(listaProfesor);
            }
        }


        public void BorrarUnaAsignatura(string asignatura)
        {
            if (asignaturas.Count == 0)
                Console.WriteLine("No existen asignaturas para borrar");
            else
            {
                for (int i = 0; i < asignaturas.Count; i++)
                {
                    if (asignaturas[i] == asignatura)
                        asignaturas.Remove(asignaturas[i]);
                    else
                    {
                        Console.WriteLine("No se ha encontrado ninguna asignatura");
                    }
                }
            }
        }

        public void MostrarProfeAsignatura(string asignatura)
        {
            for (int j = 0; j < asignaturas.Count; j++)
            {
                if (asignatura == asignaturas[j])
                {
                    Console.WriteLine(GetNameProfesor());
                    
                }

                else if(asignatura != asignaturas[j])
                {
                    Console.WriteLine("No se ha podido encontrar ninguna informacion");
                }
            }
        }

        public static void MostrarInfoProfe(List<Profesor> listaProfesores)
        {
            Console.WriteLine("Introduce nombre para mostrar los datos del profesor");
            string dni = Console.ReadLine();
            for (int i = 0; i < listaProfesores.Count; i++)
            {
                if (dni == listaProfesores[i].GetDniProfesor())
                {
                    listaProfesores[i].InfoProfesor(listaProfesores);
                }
            }
        }
    }
}
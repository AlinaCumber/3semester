using System;
using System.Collections.Generic;
using static System.Console;

namespace semester3
{
    public class AppCursos
    {
      
        static List<Curso> listaCursos = new List<Curso>();
        static List<Alumno> listaAlumnos = new List<Alumno>();
        static List<Profesor> listaProfesores = new List<Profesor>();


        public static void listaDeAlumnos()
        {
            listaAlumnos.Add(new Alumno("SteveRogers", "12345668W","Sys1"));
            listaAlumnos.Add(new Alumno("PepperPots","982309228J",new List<double>{3,4,5}, "Sys1"));
            listaAlumnos.Add(new Alumno("PiterParker", "72830203U","Sys1"));
            listaAlumnos.Add(new Alumno("NatashaRomanov","912537739Z",new List<double>{9,5,7}, "CSS2"));
            listaAlumnos.Add(new Alumno("BartonBreds", "839027492K","Sys1"));
            listaAlumnos.Add(new Alumno("Vision","263748923H",new List<double>{8,6,2}, "CSS2"));
            listaAlumnos.Add(new Alumno("BobEsponja", "186372983L","Sys1"));
            listaAlumnos.Add(new Alumno("ToniStark","6823769203X",new List<double>{4,4,3}, "Sys1"));
            listaAlumnos.Add(new Alumno("Ultron ", "9208302830B","CS4"));
            listaAlumnos.Add(new Alumno("Antman","5372836492G",new List<double>{3,8,5}, "CS4"));
            listaAlumnos.Add(new Alumno("IronMan", "12345668W","CS4"));
            listaAlumnos.Add(new Alumno("BlackWidow","739273648J",new List<double>{8,4,6}, "CS4"));            
            listaAlumnos.Add(new Alumno("CaptanAmerica","87276283Z",new List<double>{9,7,7}, "CSS2"));
            listaAlumnos.Add(new Alumno("HarryPotter","83729387K",new List<double>{8,5,6}, "GRIFINDOR"));            
            listaAlumnos.Add(new Alumno("GermionaGranger","772639203H",new List<double>{9,9,9}, "GRIFINDOR"));
            listaAlumnos.Add(new Alumno("RonWisley","93838293F",new List<double>{2,3,1}, "GRIFINDOR"));            
            
            
        }

        public static void listaDeProfesores()
        {
            listaProfesores.Add(new Profesor("BlackPanter", "81726354K"));
            listaProfesores.Add(new Profesor("Aquaman", "92836451G", new List<string>{"Matematica", "Biologia", "Sys1"}));
            listaProfesores.Add(new Profesor("Batman", "26374023E", new List<string>{"Lengua", "Literatura"}));
            listaProfesores.Add(new Profesor("Spiderman", "53729384M", new List<string>{"Pedagogia", "Ingles"}));
            listaProfesores.Add(new Profesor("TorOdinson", "22342340P", new List<string>{"Aleman", "Espionaje"}));
            listaProfesores.Add(new Profesor("LokiOdinson", "662739402V", new List<string>{"Combate", "Comer perritos calientes"}));
            listaProfesores.Add(new Profesor("Tanos", "983728973K", new List<string>{"Llevar pantalones", "Cocinar", "CS4"}));
            listaProfesores.Add(new Profesor("Fyri", "872389922N", new List<string>{"Matar a los bichos", "Fisica"}));
            listaProfesores.Add(new Profesor("NickColson", "98374928L", new List<string>{"Levitacion"}));
            listaProfesores.Add(new Profesor("Gils", "27398829H", new List<string>{"Transformacion", "Kwidich"}));
            listaProfesores.Add(new Profesor("Odin", "26372739Z", new List<string>{"Avada Kedawra", "Wingardia Leviosa", "CSS2"}));
            listaProfesores.Add(new Profesor("Frida", "23882910Q", new List<string>{"Criciatus", "End game"}));
            listaProfesores.Add(new Profesor("McGonagal", "839203947A", new List<string>{ "Blabla", "GRIFINDOR"}));
        }

        public static void listaDeCursos()
        {
            listaCursos.Add(new Curso("Systemas Informaticos", "Sys1"));
            listaCursos.Add(new Curso("Lenguaje de marcas", "CSS2"));
            listaCursos.Add(new Curso("Computer Cience", "CS4"));
            listaCursos.Add(new Curso("Godric Grifindor", "GRIFINDOR"));
            
        }
        
        

        

        public static void Start()
        {
            listaDeCursos();
            listaDeAlumnos();
            listaDeProfesores();
            Title = "Estais en APP REGISTRO de instituto MARE NOTRUM";
            RunMainMenu();
        }

        private static void RunMainMenu()
        {
            string prompt = @" 

██████╗ ███████╗ ██████╗ ██╗███████╗████████╗██████╗  ██████╗ 
██╔══██╗██╔════╝██╔════╝ ██║██╔════╝╚══██╔══╝██╔══██╗██╔═══██╗
██████╔╝█████╗  ██║  ███╗██║███████╗   ██║   ██████╔╝██║   ██║
██╔══██╗██╔══╝  ██║   ██║██║╚════██║   ██║   ██╔══██╗██║   ██║
██║  ██║███████╗╚██████╔╝██║███████║   ██║   ██║  ██║╚██████╔╝
╚═╝  ╚═╝╚══════╝ ╚═════╝ ╚═╝╚══════╝   ╚═╝   ╚═╝  ╚═╝ ╚═════╝ 
                                                              


(Utiliza las flechas para eligir opciones y ENTER para elegir";
            string[] options = {"Gestion Cursos", "Gestion Alumnos", "Gestion Profesores", "Salir"};
            MenuApp mainMenu = new MenuApp(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    Clear();
                    GestionCurso(listaCursos);
                    break;
                case 1:
                    Clear();
                    GestionAlumnos(listaAlumnos);
                    break;
                case 2:
                    Clear();
                    GestionProfesores(listaProfesores);
                    break;
            }
        }

        private static void GestionCurso(List<Curso> listaCursos)
        {

            string prompt = "Gestion Curso";
            string[] options =
            {
                "Anadir curso", "Eliminar curso", "Mostrar todos los cursos",
                "Mostrar todos los Alumnos pertenesientes a un curso", "Menu principal"
            };
            MenuApp menuCurso = new MenuApp(prompt, options);
            int selectedIndex = menuCurso.Run();

            switch (selectedIndex)
            {
                case 0:
                    Clear();
                    FuncionCurso.CreateCurso(listaCursos);
                    GestionCurso(listaCursos);
                    break;
                case 1:
                    Clear();
                    FuncionCurso.DeleteCurso(listaCursos);
                    GestionCurso(listaCursos);
                    break;
                case 2:
                    Clear();
                    ConsoleKey keyPressed;
                    do
                    {
                        Clear();
                        FuncionCurso.ImprimirListaCursos(listaCursos);
                        WriteLine("Para volver pulsar ENTER");
                        ConsoleKeyInfo keyInfo = ReadKey(true);
                        keyPressed = keyInfo.Key;
                    } while (keyPressed != ConsoleKey.Enter);

                    GestionCurso(listaCursos);

                    break;
                case 3:
                    Clear();


                    do
                    {
                        Clear();

                        if (listaAlumnos.Count == 0)
                        {
                            WriteLine("No hay de momento alumnos en este curso");
                        }
                        else
                        {
                            Clear();
                            InfoAlumnosPertenecenCurso.InfoAlumnoPorCurso(listaAlumnos);
                        }

                        WriteLine("Para volver pulsar ENTER");
                        
                        ConsoleKeyInfo keyInfo = ReadKey(true);
                        keyPressed = keyInfo.Key;
                    } while (keyPressed != ConsoleKey.Enter);

                    GestionCurso(listaCursos);

                    break;
                case 4:
                    Start();
                    break;
            }
        }

        private static void GestionAlumnos(List<Alumno> listaAlumnos)
        {
            
            string prompt = "Gestion Alumnos";
            string[] options =
            {
                "Introducir Alumno", "Eliminar Alumno", "Mostrar lista Alumnos",
                "Ordenar alumnos por orden alfabetico", "Mostrar datos alumno (por nombre)",
                "Mostrar datos alumnos pertenecientes al curso", "Anadir notas al alumno", "Eliminar notas del alumno",
                "Mostrar alumnos con la nota mayor o igual al cinco",
                "Mostrar alumnos con la nota menor que 5", "Menu principal"
            };
            MenuApp menuCurso = new MenuApp(prompt, options);
            int selectedIndex = menuCurso.Run();

            switch (selectedIndex)
            {
                case 0:
                    Clear();
                    FunctionAlumno.CreateAlumno(listaAlumnos, listaCursos);
                    GestionAlumnos(listaAlumnos);
                    break;
                case 1:
                    FunctionAlumno.DeleteAlumno(listaAlumnos);
                    GestionAlumnos(listaAlumnos);
                    break;
                case 2:
                    Clear();
                    ConsoleKey keyPressed;
                    do
                    {
                        Clear();

                        FunctionAlumno.ImprimirListaAlumnos(listaAlumnos);
                        WriteLine("Para volver pulsar ENTER");
                        ConsoleKeyInfo keyInfo = ReadKey(true);
                        keyPressed = keyInfo.Key;
                    } while (keyPressed != ConsoleKey.Enter);

                    GestionAlumnos(listaAlumnos);
                    break;
                case 3:
                    Clear();

                    do
                    {
                        Clear();

                        Alumno.OrdenarListaAlumnos(listaAlumnos);
                        WriteLine("Para volver pulsar ENTER");
                        ConsoleKeyInfo keyInfo = ReadKey(true);
                        keyPressed = keyInfo.Key;
                    } while (keyPressed != ConsoleKey.Enter);

                    GestionAlumnos(listaAlumnos);
                    break;
                case 4:
                    Clear();

                    do
                    {
                        Clear();

                        FunctionAlumno.ImprimirInfoAlumno(listaAlumnos);
                        WriteLine("Para volver pulsar ENTER");
                        ConsoleKeyInfo keyInfo = ReadKey(true);
                        keyPressed = keyInfo.Key;
                    } while (keyPressed != ConsoleKey.Enter);

                    GestionAlumnos(listaAlumnos);
                    break;

                case 5:
                    Clear();


                    do
                    {
                        Clear();

                        if (listaAlumnos.Count == 0)
                        {
                            WriteLine("No hay de momento alumnos en este curso");
                        }
                        else
                        {
                            InfoAlumnosPertenecenCurso.InfoAlumnoPorCurso(listaAlumnos);
                        }

                        WriteLine("Para volver pulsar ENTER");
                        ConsoleKeyInfo keyInfo = ReadKey(true);
                        keyPressed = keyInfo.Key;
                    } while (keyPressed != ConsoleKey.Enter);

                    GestionAlumnos(listaAlumnos);

                    break;

                case 6:
                    Clear();
                    FunctionAlumno.IntroducirNotasAlumno(listaAlumnos);
                    GestionAlumnos(listaAlumnos);
                    break;

                case 7:
                    Clear();
                    FunctionAlumno.DeleteNotas(listaAlumnos);
                    GestionAlumnos(listaAlumnos);
                    break;

                case 8:
                    Clear();

                    do
                    {
                        Clear();

                        FunctionAlumno.notaMediaMayorCinco(listaAlumnos);
                        WriteLine("Para volver pulsar ENTER");
                        ConsoleKeyInfo keyInfo = ReadKey(true);
                        keyPressed = keyInfo.Key;
                    } while (keyPressed != ConsoleKey.Enter);

                    GestionAlumnos(listaAlumnos);
                    break;

                case 9:
                    Clear();

                    do
                    {
                        Clear();

                        FunctionAlumno.notaMediaMenorCinco(listaAlumnos);
                        WriteLine("Para volver pulsar ENTER");
                        ConsoleKeyInfo keyInfo = ReadKey(true);
                        keyPressed = keyInfo.Key;
                    } while (keyPressed != ConsoleKey.Enter);

                    GestionAlumnos(listaAlumnos);

                    break;

                case 10:
                    Start();
                    break;
            }
        }

        public static void GestionProfesores(List<Profesor> listaProfesores)
        {
            
            string prompt = "Gestion Profesor";
            string[] options =
            {
                "Introducir Profesor", "Eliminar Profesor", "Mostrar lista Profesores",
                "Ordenar profesores por orden alfabetico", "Mostrar datos profesor ",
                "Anadie asignatura al profesor", "Eliminar asignatura de un profesor",
                "Mostrar profesores que imparten una asignatura", "Menu principal"
            };
            MenuApp menuCurso = new MenuApp(prompt, options);
            int selectedIndex = menuCurso.Run();

            switch (selectedIndex)
            {
                case 0:
                    Clear();
                    FunctionProfesor.CreateProfesor(listaProfesores);
                    GestionProfesores(listaProfesores);
                    break;
                case 1:
                    Clear();
                    FunctionProfesor.DeleteProgesor(listaProfesores);
                    GestionProfesores(listaProfesores);
                    break;
                case 2:
                    Clear();
                    ConsoleKey keyPressed;
                    do
                    {
                        Clear();

                        FunctionProfesor.ImprimirListaProfesor(listaProfesores);
                        WriteLine("Para volver pulsar ENTER");
                        ConsoleKeyInfo keyInfo = ReadKey(true);
                        keyPressed = keyInfo.Key;
                    } while (keyPressed != ConsoleKey.Enter);

                    GestionProfesores(listaProfesores);
                    break;
                case 3:
                    Clear();

                    do
                    {
                        Clear();

                        Profesor.OrdenarListaProfesores(listaProfesores);
                        WriteLine("Para volver pulsar ENTER");
                        ConsoleKeyInfo keyInfo = ReadKey(true);
                        keyPressed = keyInfo.Key;
                    } while (keyPressed != ConsoleKey.Enter);

                    GestionProfesores(listaProfesores);
                    break;
                case 4:
                    do
                    {
                        Clear();
                        FunctionProfesor.ImprimirInfoProfesor(listaProfesores);
                        WriteLine("Para volver pulsar ENTER");
                        ConsoleKeyInfo keyInfo = ReadKey(true);
                        keyPressed = keyInfo.Key;
                    } while (keyPressed != ConsoleKey.Enter);

                    GestionProfesores(listaProfesores);
                    break;
                case 5:
                    FunctionProfesor.IntroducirAsignaturasProfesor(listaProfesores, listaCursos);
                    GestionProfesores(listaProfesores);
                    break;
                case 6:
                    FunctionProfesor.BorrarAsignaturaDelProfe(listaProfesores);
                    GestionProfesores(listaProfesores);
                    break;
                case 7:
                    do
                    {
                        Clear();
                        FunctionProfesor.ProfesQueRepartenAsinatura(listaProfesores);

                        WriteLine("Para volver pulsar ENTER");
                        ConsoleKeyInfo keyInfo = ReadKey(true);
                        keyPressed = keyInfo.Key;
                    } while (keyPressed != ConsoleKey.Enter);
                    GestionProfesores(listaProfesores);
                    break;
                case 8:
                    Start();
                    break;
            }
        }

        private static void Salir()
        {
            WriteLine("\nPresiona cualquier tecla para salir");
            ReadKey(true);
            Environment.Exit(0);
        }
    }
}
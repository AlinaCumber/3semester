using System;
using System.Collections;
using System.Collections.Generic;

namespace semester3
{
    public class VerifyValues
    {
        public static string VerifyDni()
        {
            char[] letters =
            {
                'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C',
                'K', 'E'
            };
            Console.WriteLine("Introduce su DNI");
            introduce:
            string dni = Console.ReadLine();
            string number = dni.Remove(8, 1);
            char letter = char.ToUpper(dni[8]);

            int verify = 0;
            bool isNumber = int.TryParse(number, out verify);

            //verify if letter is in arrays
            if (!((IList) letters).Contains(letter))
            {
                Console.WriteLine("Letra introducida es INCORRECTA, untroduce su DNI otra vez.");
                goto introduce;
            }

            //verify if number is a number

            else if (!isNumber)
            {
                Console.WriteLine("El numero introducido es incorrecto");
                goto introduce;
            }

            else if (dni.Length != 9)
            {
                Console.WriteLine("DNI introcucido es incorrecto!");
                goto introduce;
            }

            int numberDni = Convert.ToInt32(number);
            int position = numberDni % 23;

            //verify if position letter is letter

            if (letters[position] != letter)
            {
                Console.WriteLine("Dni esta mal introducido");
                goto introduce;
            }
            else
            {
                dni = number + letter;
            }

            return dni;
        }

        public static string VerifyName()
        {
            string name;
            do
            {
                Console.WriteLine("Introduce nombre");
                name = Console.ReadLine();
                if (checkStr(name) == false)
                {
                    Console.WriteLine("Tienes que introducir nombre y apellido correctamente");
                }
            } while (!checkStr(name));

            return name;
        }

        public static bool checkStr(string s)
        {
            for (int i = 0; i <= s.Length; ++i)
                if (s.Contains(i.ToString()))
                    return false;
            return true;
        }

        public static bool EstaEnListaCursos(List<Curso> listaCursos, string curso)
        {
            for (int i = 0; i < listaCursos.Count; i++)
            {
                if (curso != listaCursos[i].GetCodeCurso())
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            return true;
        }

        public static string VerifyCurso(List<Curso> listaCursos)
        {
            string codigo;
            do
            {
                Console.WriteLine("Introduce codigo de curso del curso");
                codigo = Console.ReadLine();
                if (EstaEnListaCursos(listaCursos, codigo) != true)
                {
                    Console.WriteLine("El codigo esta mal introducido");
                }
            } while (!EstaEnListaCursos(listaCursos, codigo));

            return codigo;
        }

       
        
    }
}
using System;

namespace semester3
{
    public class Curso
    {
        private string nameCurso;

        public Curso(string nameCurso, string codeCourso)
        {
            this.nameCurso = nameCurso;
            this.codeCourso = codeCourso;
        }

        private string codeCourso;

        public Curso()
        {
            
        }

        public void SetNameCurso(string nameCurso)
        {
            this.nameCurso = nameCurso;
        }

        public string GetNameCurso()
        {
            return nameCurso;
        }

        public void SetCodeCurso(string codeCourso)
        {
            this.codeCourso = codeCourso;
        }

        public  string GetCodeCurso()
        {
            return codeCourso;
        }

        public void ImprimirInfoCurso()
        {
            Console.WriteLine("El nombre del curso {0}", nameCurso);
            Console.WriteLine("El codigo del curso {0}", codeCourso);
        }
    }
}
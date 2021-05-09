using System.Collections.Generic;

namespace semester3
{
    public class CursoLista
    {
        private List<Curso> listaCursos = new List<Curso>();
        
        public CursoLista(List<Curso>listaCursos)
        {
            this.listaCursos = listaCursos;
        }
    }
}
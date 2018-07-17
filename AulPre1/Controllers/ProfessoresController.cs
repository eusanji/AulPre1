using Controllers.DAL;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace Controllers
{
    public class ProfessoresController
    {
        Contexto contexto = new Contexto();

        public void InserirProf(Professor novoProf)
        {
            contexto.Professores.Add(novoProf);
            contexto.SaveChanges();
        }
        public List<Professor> ListarTodosProfessor()
        {
            return contexto.Professores.ToList();
        }
        public Professor BuscarMatriculaProfessor(int matricula)
        {
            var professor = from a in contexto.Professores
                        where a.MatriculaP == matricula
                        select a;
            return (Professor)professor;
        }
        public Professor BuscarProfID(int idProfessor)
        {
            return contexto.Professores.Find(idProfessor);
        }
        public void AtualizarP(Professor professor)
        {
            contexto.Entry(professor).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }
            public void ExcluirP(int idProfessor)
        {
            Professor professor = BuscarProfID(idProfessor);
            contexto.Professores.Remove(professor);
            contexto.SaveChanges();
        }
        
    }
}

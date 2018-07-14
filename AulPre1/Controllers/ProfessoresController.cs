using Controllers.DAL;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace Controllers
{
    public class ProfessoresController
    {
        Contexto contextoP = new Contexto();

        public void InserirProf(Professor novoProf)
        {
            contextoP.Professores.Add(novoProf);
            contextoP.SaveChanges();
        }
        public List<Professor> ListarTodosProfessor()
        {
            return contextoP.Professores.ToList();
        }
        public Professor BuscarMatriculaProfessor(int matricula)
                {
            var professor = from a in contextoP.Professores
                        where a.MatriculaP == matricula
                        select a;
            return (Professor)professor;
        }
        public Professor BuscarProfID(int idProfessor)
        {
            return contextoP.Professores.Find(idProfessor);
        }
        public void AtualizarP(Professor professor)
        {
            contextoP.Entry(professor).State = System.Data.Entity.EntityState.Modified;
            contextoP.SaveChanges();
        }
            public void ExcluirP(int idProfessor)
        {
            Professor professor = BuscarProfID(idProfessor);
            contextoP.Professores.Remove(professor);
            contextoP.SaveChanges();
        }
        
    }
}

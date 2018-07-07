using Controllers.DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class AlunosController
    {
        Contexto contexto = new Contexto(); // Banco de dados 
        //List<Aluno> tabelaAlunos = new List<Aluno>(); Valido somente para projeto anterior somente console

        public void Inserir(Aluno novoAluno)
        {
            contexto.Alunos.Add(novoAluno);
            contexto.SaveChanges();


        }
        public List<Aluno> ListarTodos()
        {
            return contexto.Alunos.ToList();
        }
        public Aluno BuscarMatriculaAluno(int matricula)
        //usando LINQ
        {
        var aluno = from a in contexto.Alunos
                    where a.Matricula == matricula
                    select a;
        return (Aluno) aluno;
        }
        public Aluno BuscarPorID (int idAluno)
        {
            return contexto.Alunos.Find(idAluno);
        }
        public void Atualizar(Aluno aluno)
        {
            contexto.Entry(aluno).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }
        public void Excluir(int idAluno)
        {
            Aluno aluno = BuscarPorID(idAluno);
            contexto.Alunos.Remove(aluno);
            contexto.SaveChanges();
          
            //tabelaAlunos.Remove(a); antigo
        }
    }
    
}

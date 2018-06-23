using Controllers;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleView
{
    class Program
    {
        static void Main(string[] args)
        {
            /**  Inserir alunos
            //Criando objeto
            AlunosController alunosController = new AlunosController();

            //Cadastrar alunos
            Aluno a = CadastraAluno();
            alunosController.Inserir(a);

            Aluno b = CadastraAluno();
            alunosController.Inserir(b);

            Aluno c = CadastraAluno();
            alunosController.Inserir(c);

            foreach (Aluno aluno in alunosController.ListarTodos())
            {
                ImprimirDadosAluno(aluno);
            }


            Console.ReadKey();
            **/

            //Inserir Professor
            //Criando objeto
            ProfessoresController pC = new ProfessoresController();

            Professor d = CadastrarProfessor();
            pC.InserirProf(d);

            Professor e = CadastrarProfessor();
            pC.InserirProf(e);

            foreach(Professor p in pC.ListarTodosProfessor())
            {
                ImprimirDadoProfessor(p);

            }
            Console.ReadKey();
        }

        private static void ImprimirDadoProfessor(Professor p)
        {
            Console.WriteLine("Professor : " + p.NomeP);
            Console.WriteLine("Matricula do Professor : " + p.MatriculaP);
        }

        private static Professor CadastrarProfessor()
        {
            Professor p = new Professor();

            Console.Write("Digite o nome do professor: ");
            p.NomeP = Console.ReadLine();

            Console.Write("Digite a matricula do professor: ");
            p.MatriculaP = int.Parse(Console.ReadLine());
            return p;
        }

        private static void ImprimirDadosAluno(Aluno a)
        {
            Console.WriteLine("Aluno: " + a.Nome);//get
            Console.WriteLine("Matricula : " + a.Matricula);//get
        }

        private static Aluno CadastraAluno()
        {
            Aluno a = new Aluno();
            
            Console.Write("Digite o aluno : ");
            a.Nome = Console.ReadLine();//set

            Console.Write("Digite a matricula: ");
            a.Matricula = int.Parse(Console.ReadLine());//set
            return a;
        }
    }
}

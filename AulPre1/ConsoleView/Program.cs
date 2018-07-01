using Controllers;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace ConsoleView
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.WriteLine("EEscola uma opção");
                Console.WriteLine("1 - Deletar o Aluno", a);
                Console.WriteLine("2 - Para listar 'Alunos'");
                Console.WriteLine("3 - Para listar 'Professores'");
                Console.WriteLine("4- Para listar 'Disciplinas'");
                Console.WriteLine("0 - Para Finalizar");
                Console.WriteLine("Digite a opção que deseja: ");
                opcao = Int32.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        AlunosController.Delete(a);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Lista de Alunos");
                        Console.WriteLine("");
                        foreach (Aluno aluno in alunosController.ListarTodos())
                        {
                            ImprimirDadosAluno(aluno);
                        }
                        Console.WriteLine("\nAperte 'Enter' Para Voltar ao Menu!");
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("\n Lista de Professores");
                        foreach (Professor p in professoresController.ListarTodos())
                        {
                            ImprimirDadoProfessor(p);
                        }
                        Console.WriteLine("\nAperte 'Enter' Para Voltar ao Menu!");
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("\n Lista de Disciplina");
                        foreach (Disciplina disciplina in disciplinaController.ListarDisciplinas())
                        {
                            ImprimirDisciplinas (disciplina);
                        }
                        Console.WriteLine("\nAperte 'Enter' Para Voltar ao Menu!");
                        break;
                }
                Console.ReadKey();
                Console.Clear();

            } while (opcao != 0);

            foreach (Aluno aluno in alunosController.ListarTodos())
            {
                ImprimirDadosAluno(aluno);
            }

            /**
            //Criando objeto
            AlunosController alunosController = new AlunosController();

            //Cadastrar alunos
            Aluno a = CadastraAluno();
            alunosController.Inserir(a);

            foreach (Aluno aluno in alunosController.ListarTodos())
            {
                ImprimirDadosAluno(aluno);
            }
            
            Console.ReadKey();
            **/

            /**
            
            //Inserir Professor
            //Criando objeto
            ProfessoresController pC = new ProfessoresController();

            Professor b = CadastrarProfessor();
            pC.InserirProf(b);

            foreach(Professor p in pC.ListarTodosProfessor())
            {
                ImprimirDadoProfessor(p);

            }
            Console.ReadKey();
            
            //Inserir disciplina
            DisciplinaController dC = new DisciplinaController();

            Disciplina c = CadastrarDisciplina();
            dC.Inserird(c);

            foreach(Disciplina d in dC.ListarDisciplinas())
            {
                ImprimirDisciplinas(d);
            }
            Console.ReadKey();
          **/
        }

        private static void ImprimirDisciplinas(Disciplina d)
        {
            Console.WriteLine("Disciplina : " + d.NomeD);
            Console.WriteLine("Carga Horaria : " + d.CargaHoraria);
            

        }

        private static Disciplina CadastrarDisciplina()
        {
            Disciplina f = new Disciplina();

            Console.WriteLine("Digite a descrição da disciplina");
            f.NomeD = Console.ReadLine();

            Console.WriteLine("Digte a carga horaria da disciplina");
            f.CargaHoraria = int.Parse(Console.ReadLine());
            return f;
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

        public static Aluno CadastraAluno(string Nome, int Matricula)
        {
            Aluno a = new Aluno();
            var aluno = a.alunos.Create();


            
            Console.Write("Digite o aluno : ");
            a.Nome = Console.ReadLine();//set

            Console.Write("Digite a matricula: ");
            a.Matricula = int.Parse(Console.ReadLine());//set
            return a;
        }
    }
}

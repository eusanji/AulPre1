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
             //Criando usuario
            Console.WriteLine("-----------------Aluno-----------------------");
            AlunosController alunosController = new AlunosController();
            Aluno a = CadastraAluno();
            alunosController.Inserir(a);
             
            //Criando objeto
            ProfessoresController pC = new ProfessoresController();
            Console.WriteLine("----------------Professor--------------");
            Professor b = CadastrarProfessor();
            pC.InserirProf(b);
            
            //Inserir disciplina
            DisciplinaController dC = new DisciplinaController();
            Console.WriteLine("----------------Disciplina--------------");
            Disciplina c = CadastrarDisciplina();
            dC.Inserird(c);
           // Console.ReadKey();
            
            int opcao;
            do
            {
                Console.WriteLine("Escolha uma opção");
                Console.WriteLine("1 - Para listar 'Alunos'");
                Console.WriteLine("2 - Para listar 'Professores'");
                Console.WriteLine("3 - Para listar 'Disciplinas'");
                Console.WriteLine("4 - Deletar o Aluno", a);
                Console.WriteLine("5 - Deletar um professor", b);
                Console.WriteLine("6 - Deletar uma disciplina", c);
                Console.WriteLine("0 - Para Finalizar");
                Console.Write("Digite uma opção e tecle Enter: ");
                opcao = Int32.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Lista de Alunos");
                        Console.WriteLine("");
                        foreach (Aluno aluno in alunosController.ListarTodos())
                        {
                            ImprimirDadosAluno(aluno);
                        }
                        Console.WriteLine("\n Aperte 'Enter' Para Voltar ao Menu!");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Lista de Professores");
                        Console.WriteLine("");
                        foreach (Professor p in pC.ListarTodosProfessor())
                        {
                            ImprimirDadoProfessor(p);
                        }
                        Console.WriteLine("\n Aperte 'Enter' Para Voltar ao Menu!");
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Lista de Disciplina");
                        Console.WriteLine("");
                        foreach (Disciplina disciplina in dC.ListarDisciplinas())
                        {
                            ImprimirDisciplinas(disciplina);
                        }
                        Console.WriteLine("\nAperte 'Enter' Para Voltar ao Menu!");
                        break;
                    case 4:

                        alunosController.Delete(a);
                        Console.WriteLine("Aluno excluido com sucesso tecle Enter para voltar ao menu");
                        break;
                    case 5:
                        pC.Delete(b);
                        Console.WriteLine("Professor excluido com sucesso tecle Enter para voltar ao menu");
                        break;
                    case 6:
                        dC.Delete(c);
                        Console.WriteLine("Disciplina excluido com sucesso tecle Enter para voltar ao menu");
                        break;
                }
                
                Console.ReadKey();
                Console.Clear();

            } while (opcao != 0);
                        
        }

        private static void ImprimirDisciplinas(Disciplina d)
        {
            Console.WriteLine("Disciplina : " + d.NomeD);
            Console.WriteLine("Carga Horaria : " + d.CargaHoraria);
        }
        private static Disciplina CadastrarDisciplina()
        {
            Disciplina f = new Disciplina();

            Console.Write("Digite a descrição da disciplina: ");
            f.NomeD = Console.ReadLine();

            Console.Write("Digte a carga horaria da disciplina: ");
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
        public static Aluno CadastraAluno()
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

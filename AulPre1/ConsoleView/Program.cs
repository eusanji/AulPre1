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
          
            //Criando objeto
            AlunosController alunosController = new AlunosController();
            
            //Cadastrar alunos
            Aluno a = CadastraAluno();
            alunosController.Inserir(a);

            Aluno b = CadastraAluno();
            alunosController.Inserir(b);

            Aluno c = CadastraAluno();
            alunosController.Inserir(c);

            foreach(Aluno aluno in alunosController.ListarTodos())
            {
                ImprimirDadosAluno(aluno);
            }


            Console.ReadKey();
        }

        private static void ImprimirDadosAluno(Aluno a)
        {
            Console.WriteLine("Aluno: " + a.Nome);//get
            Console.WriteLine("Matricula: " + a.Matricula);//get
        }

        private static Aluno CadastraAluno()
        {
            Aluno a = new Aluno();
            
            Console.WriteLine("Digite o aluno");
            a.Nome = Console.ReadLine();//set

            Console.WriteLine("Digite a matricula");
            a.Matricula = int.Parse(Console.ReadLine());//set
            return a;
        }
    }
}

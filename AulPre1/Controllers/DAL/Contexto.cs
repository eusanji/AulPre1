using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.DAL
{
    public class Contexto : DbContext
    {
        public Contexto() : base("strConn") // Classe mãe (Super do Java)
        {

        }

        public DbSet<Aluno> Alunos { get; set; }
    }
}

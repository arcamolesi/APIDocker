using Microsoft.EntityFrameworkCore;

namespace APIDocker
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) :
            base(options)
        { }

        public DbSet<Aluno> Alunos { get; set; }

    }
}

using Microsoft.EntityFrameworkCore;
using WebAPI_SprintAPI_Escola.Models;

namespace WebAPI_SprintAPI_Escola.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) 
        : base(options) { }
    
    public DbSet<Aluno> Alunos { get; set; }
    public DbSet<Turma> Turmas { get; set; }
    public DbSet<Professor> Professores { get; set; }
    public DbSet<Disciplina> Disciplinas { get; set; }
    public DbSet<Responsavel> Responsaveis { get; set; }
    public DbSet<Nota> Notas { get; set; }

    public DbSet<AlunoResponsavel> AlunosResponsaveis { get; set; }
    public DbSet<AlunoTurma> AlunosTurmas { get; set; }
    public DbSet<ProfessorDisciplina> ProfessoresDisciplinas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // ============================================
        // Configuração das Chaves Primárias Compostas
        // ============================================

        // Aluno_Responsavel
        modelBuilder.Entity<AlunoResponsavel>()
            .HasKey(ar => new { ar.IdAluno, ar.IdResponsavel });

        // Aluno_Turma
        modelBuilder.Entity<AlunoTurma>()
            .HasKey(at => new { at.IdAluno, at.IdTurma });

        // Professor_Disciplina
        modelBuilder.Entity<ProfessorDisciplina>()
            .HasKey(pd => new { pd.IdProfessor, pd.IdDisciplina });


        // ============================================
        // Configuração opcional (mas recomendada) de 
        // chaves primárias padrão para manter os nomes 
        // idênticos ao seu PlantUML
        // ============================================
        
        modelBuilder.Entity<Aluno>().HasKey(a => a.IdAluno);
        modelBuilder.Entity<Turma>().HasKey(t => t.IdTurma);
        modelBuilder.Entity<Professor>().HasKey(p => p.IdProfessor);
        modelBuilder.Entity<Disciplina>().HasKey(d => d.IdDisciplina);
        modelBuilder.Entity<Responsavel>().HasKey(r => r.IdResponsavel);
        modelBuilder.Entity<Nota>().HasKey(n => n.IdNota);
    }
}

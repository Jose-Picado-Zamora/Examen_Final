using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Services.MyDbContext
{
    public class MyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("MyDatabase");
        }
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Carrera> Carreras { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Nivel> Niveles { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Curso>()
                .HasOne(nivel => nivel.Nivel);

            modelBuilder.Entity<Curso>()
                .HasMany(estudiantes => estudiantes.ListaEstudiantes)
                .WithOne(curso => curso.Curso);

            modelBuilder.Entity<Matricula>()
                .HasOne(matricula => matricula.Estudiante);

            modelBuilder.Entity<Matricula>()
                .HasOne(matricula => matricula.Curso);

            modelBuilder.Entity<Estudiante>()
                .HasOne(curso => curso.Curso)
                .WithMany(estudiantes => estudiantes.ListaEstudiantes);

            modelBuilder.Entity<Estudiante>()
                .HasOne(c => c.Carrera)
                .WithMany(estudiantes => estudiantes.ListaEstudiantes);

            modelBuilder.Entity<Carrera>()
                .HasMany(cursos => cursos.ListaCursos);
        }
    }
}

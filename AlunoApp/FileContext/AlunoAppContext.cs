using AlunoApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlunoApp.FileContext
{
    public class AlunoAppContext : DbContext
    {
        public DbSet<AlunoModel> Aluno { get; set; }
        public DbSet<ModelConsulta> model { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AlunosCadastroDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<AlunoModel>().Property(p => p.Nome).HasColumnType("VARCHAR(100)");

            modelBuilder.Entity<AlunoModel>().HasKey(p => p.AlunoId);

            modelBuilder.Entity<AlunoModel>().Property(p => p.DataDeNascimento).HasColumnName("Data de Nascimento");
            modelBuilder.Entity<AlunoModel>().Property(p => p.DataDeNascimento).HasColumnType("DATE");


            modelBuilder.Entity<AlunoModel>().Property(p => p.Matricula).HasColumnType("VARCHAR(4)");
        }
    }
}

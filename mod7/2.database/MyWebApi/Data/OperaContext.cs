using Microsoft.EntityFrameworkCore;
using MyWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApi.Data
{
    public class OperaContext : DbContext
    {
        public OperaContext(DbContextOptions<OperaContext> options) : base(options) { }

        public DbSet<Opera> Operas { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Opera>().HasData(
                new Opera
                {
                    OperaID = 1,
                    Title = "Cosi Fan Tutte",
                    Year = 1790,
                    Composer = "Wolfgang Amadeus Mozart",
                },
                 new Opera
                 {
                     OperaID = 2,
                     Title = "Rigoletto",
                     Year = 1851,
                     Composer = "Giuseppe Verdi",
                 },
                 new Opera
                 {
                     OperaID = 3,
                     Title = "Nixon in China",
                     Year = 1987,
                     Composer = "John Adams"
                 },
                 new Opera
                 {
                     OperaID = 4,
                     Title = "Wozzeck",
                     Year = 1922,
                     Composer = "Alban Berg"
                 }
             );
        }
    }
}

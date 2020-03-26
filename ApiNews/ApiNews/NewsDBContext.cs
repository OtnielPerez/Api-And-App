using ApiNews.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiNews
{
    public class NewsDBContext : DbContext
    {
        public NewsDBContext(DbContextOptions opciones): base(opciones)
        {

        }

        public DbSet<News> News { get; set; }
        public DbSet<Author> Author { get; set; }


        protected override void OnModelCreating(ModelBuilder ModeloCreador)
        {
            new News.Mapeo(ModeloCreador.Entity<News>());
            new Author.Mapeo(ModeloCreador.Entity<Author>());
        }



    }
}

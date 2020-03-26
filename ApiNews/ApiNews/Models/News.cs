using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ApiNews.Models
{
    public class News
    {
        public int Idnews { get; set; }
        public string Title { get; set; }
        public string Descrip { get; set; }
        public DateTime Fecha { get; set; }
        public string Content { get; set; }  
        public int Idauthor { get; set; }
        public Author Author { get; set; }

        public class Mapeo
        {
            public Mapeo(EntityTypeBuilder<News> MapeoNews)
            {
                MapeoNews.HasKey(i => i.Idnews);
                MapeoNews.Property(i => i.Title);
                MapeoNews.Property(i => i.Descrip);
                MapeoNews.HasOne(i => i.Author);
                //MapeoNews.ToTable("News");
            }
        }

        public class news
        {
        }
    }
}

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiNews.Models
{
    public class Author
    {
        public int Idauthor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public class Mapeo
        {
            public Mapeo(EntityTypeBuilder<Author> MapeoAuthor)
            {
                MapeoAuthor.HasKey(i => i.Idauthor);
                MapeoAuthor.Property(i => i.Nombre);
                MapeoAuthor.Property(i => i.Apellido);
                
            }  
        }
    }
}

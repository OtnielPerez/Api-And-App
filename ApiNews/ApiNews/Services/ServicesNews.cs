using ApiNews.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ApiNews.Models.News;

namespace ApiNews.Services
{
    public class ServicesNews
    {
        private readonly NewsDBContext newsDB;
        public ServicesNews(NewsDBContext noticiaDBContext)
        {
           newsDB = noticiaDBContext;
        }

        public List<News> Obtener()
        {
         var  resultado =  newsDB.News.Include(x => x.Author).ToList();
            return resultado;
        }
        public Boolean Addnews(News _news) 
        {
            try
            {
                newsDB.News.Add(_news);
                newsDB.SaveChanges();

                return true;
            }
            catch(Exception Error)
            {
                return false; 
            }

        }

        public Boolean EditNews(News _news)
        {
            try
            {
                var NewsDatabase = newsDB.News.Where(x => x.Idnews == _news.Idnews).FirstOrDefault();
                NewsDatabase.Title = _news.Title;
                NewsDatabase.Descrip = _news.Descrip;
                NewsDatabase.Fecha = _news.Fecha;
                NewsDatabase.Content = _news.Content;
                NewsDatabase.Idauthor = _news.Idauthor;
                newsDB.SaveChanges();
                return true;
            }
            catch(Exception Error)
            {
                return false;
            }
        }

        public Boolean DeleteNews(int IdNews)
        {
            try
            {
                var NewsDatabase = newsDB.News.Where(x => x.Idnews == IdNews).FirstOrDefault();
                newsDB.News.Remove(NewsDatabase);
                newsDB.SaveChanges();
                return true;
            }
            catch(Exception Error)
            {
                return false;
            }
        }

        
    }
}

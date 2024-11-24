using Microsoft.EntityFrameworkCore;
using MyBlogProject.DataAccessLayer.Abstract;
using MyBlogProject.DataAccessLayer.Context;
using MyBlogProject.DataAccessLayer.Repositories;
using MyBlogProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogProject.DataAccessLayer.EntityFramework
{
    public class EfArticleDal : GenericRepository<Article>, IArticleDal
    {
        private readonly BlogContext _context;
        public EfArticleDal(BlogContext context) : base(context)
        {
           _context = context;
        }

        public List<Article> ArticleListWithCategory()
        {           
            var values =_context.Articles.Include(x=>x.Category).ToList();
            return values;
        }
    }
}

﻿using MyBlogProject.BusinessLayer.Abstract;
using MyBlogProject.DataAccessLayer.Abstract;
using MyBlogProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogProject.BusinessLayer.Concrete
{
    public class ArticleManager : IArticleService
    {
        private readonly IArticleDal _articleDal;

        public ArticleManager(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }

        public List<Article> TArticleListWithCategory()
        {
           return _articleDal.ArticleListWithCategory();
        }

        public void TDelete(int id)
        {
           _articleDal.Delete(id);
        }

        public List<Article> TGetAll()
        {
            return _articleDal.GetAll();
        }

        public Article TGetById(int id)
        {
           return _articleDal.GetById(id);
        }

        public void TInsert(Article entity)
        {
           _articleDal.Insert(entity);
        }

        public void TUpdate(Article entity)
        {
          _articleDal.Update(entity);   
        }
    }
}

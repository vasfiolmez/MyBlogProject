﻿using MyBlogProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogProject.DataAccessLayer.Abstract
{
    public interface IArticleDal:IGenericDal<Article>
    {
       public List<Article> ArticleListWithCategory();
        public List<Article> ArticleListWithCategoryAndAppUser();
    }
}

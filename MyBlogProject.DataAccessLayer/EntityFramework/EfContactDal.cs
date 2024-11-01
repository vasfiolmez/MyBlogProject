﻿using MyBlogProject.DataAccessLayer.Abstract;
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
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
        public EfContactDal(BlogContext context) : base(context)
        {
        }
    }
}

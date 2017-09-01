﻿using Ninject.Modules;
using OnlineStore.Business.Contracts;
using OnlineStore.Business.Services;
using OnlineStore.Data.Contracts;
using OnlineStore.Data.EntityFramework;
using OnlineStore.Data.EntityFramework.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            ///Services
            Bind<IProductService>().To<ProductService>();
            Bind<ICategoryService>().To<CategoryService>();
            Bind<IUserService>().To<UserService>();

            ///Repositories
            Bind<IProductRepository>().To<ProductRepository>();
            Bind<ICategoryRepository>().To<CategoryRepository>();
            Bind<IUserRespository>().To<UserRepository>().InSingletonScope();

            ///Context
            Bind<DbContext>().To<OnlineStoreContext>();
            
        }
    }
}
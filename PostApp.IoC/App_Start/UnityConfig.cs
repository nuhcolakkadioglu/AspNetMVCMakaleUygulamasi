using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using PostApp.Core.Entities;
using PostApp.Data.GenericRepository;
using PostApp.Data.UnitofWork;
using PostApp.Services.Interfaces;
using PostApp.Services.Services;

namespace PostApp.IoC
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            //PM> Install-package Unity
            //PM> Install-package Unity.mvc5

            var container = new UnityContainer();
            RegisterTypes(container);
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
        }

        public static void RegisterTypes(IUnityContainer container)
        {
            container.BindInRequestScope<IUnitofWork, UnitofWork>();
            container.BindInRequestScope<IUserServices, UserServices>();
            container.BindInRequestScope<IGenericRepository<User>, IGenericRepository<User>>();
            container.BindInRequestScope<IGenericRepository<Post>, IGenericRepository<Post>>();
            container.BindInRequestScope<IGenericRepository<Category>, IGenericRepository<Category>>();

        }
    }

    public static class IOCExtensions
    {
        public static void BindInRequestScope<T1, T2>(this IUnityContainer container) where T2 : T1
        {
            container.RegisterType<T1, T2>(new HierarchicalLifetimeManager());
        }
    }
}
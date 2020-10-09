using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using Autofac.Core;
using System.Web.Mvc;
using Autofac.Integration.Mvc;
using System.Reflection;
using AutfacDemo.BL;

namespace AutofacDemo.Frontend
{
    public class AutofacDemoModule : Autofac.Module
    {
        public static void Load()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<EmployeeController>().As<IEmployee>();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
using Autofac;
using AutfacDemo.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutfacDemo.BL
{
    public static class AutofacBLModule
    {
        public static ContainerBuilder Load(this ContainerBuilder builder)
        {
            //builder.RegisterType<Employee>
            return builder;
        }
    }
}

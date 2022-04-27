using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Autofac;
using Module = Autofac.Module;

namespace Persistence.Modules
{
    public class PersistenceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assembly = Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).Where(t => t.Name.EndsWith("Repository")).AsSelf();
        }
    }
}

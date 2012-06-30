using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;
using Ninject;
using Ninject.Activation;
using Ninject.Parameters;
using Ninject.Syntax;

namespace MvcBootStrap.Web.Infrastructure
{
    //Make sure the IDependencyResolver is from the System.Web.Http.Dependencies namespace
    public class NinjectWebApiDependencyResolver : NinjectDependencyScope, IDependencyResolver 
    {
        private IKernel _kernel;

        public NinjectWebApiDependencyResolver(IKernel kernel) : base(kernel)
        {
            _kernel = kernel;
        }

        public IDependencyScope BeginScope()
        {
            return new NinjectDependencyScope(_kernel.BeginBlock());
        }
    }
}
[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(UnitTestProject1.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(UnitTestProject1.App_Start.NinjectWebCommon), "Stop")]

namespace UnitTestProject1.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(Ninject.Web.Common.WebHost.OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(Ninject.Web.Common.WebHost.NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
#pragma warning disable CS0618 // Type or member is obsolete
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
#pragma warning restore CS0618 // Type or member is obsolete
        {
#pragma warning disable CS0618 // Type or member is obsolete
            var kernel = new StandardKernel();
#pragma warning restore CS0618 // Type or member is obsolete
            try
            {
#pragma warning disable CS0618 // Type or member is obsolete
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
#pragma warning restore CS0618 // Type or member is obsolete
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

#pragma warning disable CS0618 // Type or member is obsolete
        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
#pragma warning restore CS0618 // Type or member is obsolete
        {
        }        
    }
}
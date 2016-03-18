using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MVCSample.Services;
using MVCSample.Data;
using System.Configuration;
using MVCSample.Core.Domain;

namespace MVCSample.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            #region DependecyResolver

            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.Register(c => c.Resolve<HttpContextBase>().Request)
                .As<HttpRequestBase>()
                .InstancePerRequest();
            builder.Register(c => c.Resolve<HttpContextBase>().Response)
                .As<HttpResponseBase>()
                .InstancePerRequest();
            builder.Register(c => c.Resolve<HttpContextBase>().Server)
                .As<HttpServerUtilityBase>()
                .InstancePerRequest();
            builder.Register(c => c.Resolve<HttpContextBase>().Session)
                .As<HttpSessionStateBase>()
                .InstancePerRequest();

            string connectionString = ConfigurationManager.ConnectionStrings["MVCSConnectionString"].ToString();
            builder.RegisterType<EFObjectContext>().As<Data.IDbContext>().WithParameter("nameOrConnectionString", connectionString).InstancePerRequest();
            builder.RegisterType<AlbumService>().As<IAlbumService>().InstancePerRequest();
            builder.RegisterType<Data.EfRepository<Album>>().As<Data.IRepository<Album>>().InstancePerRequest();
            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            #endregion

            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}

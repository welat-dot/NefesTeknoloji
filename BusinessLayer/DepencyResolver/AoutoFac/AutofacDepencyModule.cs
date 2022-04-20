using Autofac;
using BusinessLayer.Abstract;
using BusinessLayer.Concreate;
using DataLayer.Abstarct;
using DataLayer.Concreate;

namespace BusinessLayer.DepencyResolver.AoutoFac
{
    public class AutofacDepencyModule : Module
    {
       protected override void Load(ContainerBuilder builder)
       {
            builder.RegisterType<BirimManager>().As<IBirimManager>();
            builder.RegisterType<PersonelManager>().As<IPersonelManager>();
            builder.RegisterType<UserManager>().As<IUserManager>();


            builder.RegisterType<AuthService>().As<IAuthService>();
            builder.RegisterType<BirimService>().As<IBirimService>();
            builder.RegisterType<PersonelService>().As<IPersonelService>();
            builder.RegisterType<UserManager>().As<IUserService>();



        }
    }
}

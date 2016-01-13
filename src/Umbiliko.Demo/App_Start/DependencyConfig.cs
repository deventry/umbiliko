using Microsoft.AspNet.Identity.Owin;
using System.Web;
using Umbiliko.Web.Contracts;
using Umbiliko.Web.Services;

namespace Umbiliko.Demo
{
    public class DependencyConfig
    {
        public static void RegisterServices()
        {
            ServicesContainer.Default.Register<IPasswordHasher, PasswordHasher>();
            //ServicesContainer.Default.Register<ISmsService, TwilioSmsService>();
            ServicesContainer.Default.Register<ISmtpService, SmtpService>();
            ServicesContainer.Default.Register(() => System.Web.HttpContext.Current.GetOwinContext());
            ServicesContainer.Default.Register<IAuthenticationContext>(() => System.Web.HttpContext.Current.GetOwinContext().Get<IAuthenticationContext>());
            /*ServicesContainer.Default.Register<ProductContext>((Func<ProductContext>)(() =>
            {
                var owinContext = System.Web.HttpContext.Current.GetOwinContext();
                var dbContext = owinContext.Get<Entities.UmbilikoDbContext>();
                var assembly = BuildManager.GetGlobalAsaxType().BaseType.Assembly;
                var companyCode = assembly.GetCustomAttributes<AssemblyTrademarkAttribute>().Select(attr => attr.Trademark).FirstOrDefault();
                var productName = assembly.GetCustomAttributes<AssemblyProductAttribute>().Select(attr => attr.Product).FirstOrDefault();

                var company = CompanyContext.Find(dbContext, companyCode);

                return ProductContext.Find((CompanyContext)company, productName);
            }));*/
        }
    }
}

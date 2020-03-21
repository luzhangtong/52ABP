using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using my52abp.Configuration;

namespace my52abp.Web.Host.Startup
{
    [DependsOn(
       typeof(my52abpWebCoreModule))]
    public class my52abpWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public my52abpWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(my52abpWebHostModule).GetAssembly());
        }
    }
}

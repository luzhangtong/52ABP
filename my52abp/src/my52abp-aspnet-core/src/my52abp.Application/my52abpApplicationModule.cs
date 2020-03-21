using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using my52abp.Authorization;

namespace my52abp
{
    [DependsOn(
        typeof(my52abpCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class my52abpApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<my52abpAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(my52abpApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}

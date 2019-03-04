using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using react-core-boilerplate.Authorization;

namespace react-core-boilerplate
{
    [DependsOn(
        typeof(react-core-boilerplateCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class react-core-boilerplateApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<react-core-boilerplateAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(react-core-boilerplateApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}

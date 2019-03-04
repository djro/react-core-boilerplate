using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using react-core-boilerplate.Configuration;

namespace react-core-boilerplate.Web.Host.Startup
{
    [DependsOn(
       typeof(react-core-boilerplateWebCoreModule))]
    public class react-core-boilerplateWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public react-core-boilerplateWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(react-core-boilerplateWebHostModule).GetAssembly());
        }
    }
}

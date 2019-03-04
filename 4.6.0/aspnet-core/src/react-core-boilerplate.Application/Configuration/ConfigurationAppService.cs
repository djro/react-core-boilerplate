using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using react-core-boilerplate.Configuration.Dto;

namespace react-core-boilerplate.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : react-core-boilerplateAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

using System.Threading.Tasks;
using react-core-boilerplate.Configuration.Dto;

namespace react-core-boilerplate.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

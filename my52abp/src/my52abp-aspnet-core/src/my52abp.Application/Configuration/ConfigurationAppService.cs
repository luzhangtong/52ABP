using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using my52abp.Configuration.Dto;

namespace my52abp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : my52abpAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using razecsystem.Configuration.Dto;

namespace razecsystem.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : razecsystemAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

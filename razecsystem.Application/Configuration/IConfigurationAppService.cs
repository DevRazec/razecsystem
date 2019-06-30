using System.Threading.Tasks;
using Abp.Application.Services;
using razecsystem.Configuration.Dto;

namespace razecsystem.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
using System.Threading.Tasks;
using my52abp.Configuration.Dto;

namespace my52abp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

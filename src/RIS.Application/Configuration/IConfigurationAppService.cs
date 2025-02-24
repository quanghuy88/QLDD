using System.Threading.Tasks;
using RIS.Configuration.Dto;

namespace RIS.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

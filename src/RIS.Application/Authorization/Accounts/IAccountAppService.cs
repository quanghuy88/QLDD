using System.Threading.Tasks;
using Abp.Application.Services;
using RIS.Authorization.Accounts.Dto;

namespace RIS.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

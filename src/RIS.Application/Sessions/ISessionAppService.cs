using System.Threading.Tasks;
using Abp.Application.Services;
using RIS.Sessions.Dto;

namespace RIS.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

using Abp.Application.Services;
using RIS.MultiTenancy.Dto;

namespace RIS.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}


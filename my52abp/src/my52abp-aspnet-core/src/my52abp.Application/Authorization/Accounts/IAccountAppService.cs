using System.Threading.Tasks;
using Abp.Application.Services;
using my52abp.Authorization.Accounts.Dto;

namespace my52abp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

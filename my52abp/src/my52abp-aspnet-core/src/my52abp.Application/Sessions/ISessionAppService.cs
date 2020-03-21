using System.Threading.Tasks;
using Abp.Application.Services;
using my52abp.Sessions.Dto;

namespace my52abp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

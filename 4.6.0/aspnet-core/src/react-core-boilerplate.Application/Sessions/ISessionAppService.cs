using System.Threading.Tasks;
using Abp.Application.Services;
using react-core-boilerplate.Sessions.Dto;

namespace react-core-boilerplate.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

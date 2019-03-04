using System.Threading.Tasks;
using Abp.Application.Services;
using react-core-boilerplate.Authorization.Accounts.Dto;

namespace react-core-boilerplate.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

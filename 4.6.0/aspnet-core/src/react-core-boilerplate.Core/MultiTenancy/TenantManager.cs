using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using react-core-boilerplate.Authorization.Users;
using react-core-boilerplate.Editions;

namespace react-core-boilerplate.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}

using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using RIS.Authorization;

namespace RIS
{
    [DependsOn(
        typeof(RISCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class RISApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<RISAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(RISApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}

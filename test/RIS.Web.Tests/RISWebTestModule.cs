using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using RIS.EntityFrameworkCore;
using RIS.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace RIS.Web.Tests
{
    [DependsOn(
        typeof(RISWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class RISWebTestModule : AbpModule
    {
        public RISWebTestModule(RISEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RISWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(RISWebMvcModule).Assembly);
        }
    }
}
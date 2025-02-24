﻿using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using RIS.Configuration.Dto;

namespace RIS.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : RISAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

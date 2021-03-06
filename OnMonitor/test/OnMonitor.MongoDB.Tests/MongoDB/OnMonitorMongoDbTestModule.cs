﻿using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;

namespace OnMonitor.MongoDB
{
    [DependsOn(
        typeof(OnMonitorTestBaseModule),
        typeof(OnMonitorMongoDbModule)
        )]
    public class OnMonitorMongoDbTestModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var connectionString = MongoDbFixture.ConnectionString.EnsureEndsWith('/') +
                                   "Db_" +
                                    Guid.NewGuid().ToString("N");

            Configure<AbpDbConnectionOptions>(options =>
            {
                options.ConnectionStrings.Default = connectionString;
            });
        }
    }
}
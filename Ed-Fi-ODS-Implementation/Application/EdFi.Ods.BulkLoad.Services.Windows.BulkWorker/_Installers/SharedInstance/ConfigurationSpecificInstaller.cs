﻿using Castle.Windsor;
using EdFi.Ods.Common._Installers;

namespace EdFi.Ods.BulkLoad.Services.Windows.BulkWorker._Installers.SharedInstance
{
    public class ConfigurationSpecificInstaller : ConfigurationSpecificInstallerBase
    {
        protected override void RegisterDatabaseConnectionStringProviders(IWindsorContainer container)
        {
            container.Install(new SharedInstanceEnvironmentDatabaseConnectionStringInstaller());
        }
    }
}
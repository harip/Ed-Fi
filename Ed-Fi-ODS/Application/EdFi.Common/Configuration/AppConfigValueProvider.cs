// *************************************************************************
// �2013 Ed-Fi Alliance, LLC. All Rights Reserved.
// *************************************************************************

using System.Configuration;

namespace EdFi.Common.Configuration
{
    public class AppConfigValueProvider : IConfigValueProvider
    {
        public string GetValue(string name)
        {
            return ConfigurationManager.AppSettings[name];
        }
    }
}

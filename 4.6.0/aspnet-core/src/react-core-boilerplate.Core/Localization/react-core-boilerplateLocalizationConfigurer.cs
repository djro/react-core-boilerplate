using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace react-core-boilerplate.Localization
{
    public static class react-core-boilerplateLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(react-core-boilerplateConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(react-core-boilerplateLocalizationConfigurer).GetAssembly(),
                        "react-core-boilerplate.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}

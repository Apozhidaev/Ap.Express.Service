using System.Configuration;

namespace Express.Template.Modules.Api
{
    public class ModuleSection : ConfigurationSection
    {
        [ConfigurationProperty("baseAddress", IsRequired = true)]
        public string BaseAddress => (string)this["baseAddress"];
    }
}
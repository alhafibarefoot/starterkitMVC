using Microsoft.EntityFrameworkCore;
using StarterKitAspNetCoreWebApp.CustomAttributes;

namespace StarterKitAspNetCoreWebApp.CustomConnventions
{
    public class SqlDefaultValueAttributeConvention
    {
        public static void Apply(ModelBuilder builder)
    {
        ConventionBehaviors
            .SetSqlValueForPropertiesWithAttribute<SqlDefaultValueAttribute>(builder, x => x.DefaultValue);
    }
    }
}
using Microsoft.EntityFrameworkCore;
using StarterKitAspNetCoreWebApp.CustomAttributes;

namespace StarterKitAspNetCoreWebApp.CustomConnventions
{
    public class DecimalPrecisionAttributeConvention
    {
        public static void Apply(ModelBuilder builder)
    {
        ConventionBehaviors
            .SetTypeForPropertiesWithAttribute<DecimalPrecisionAttribute>(builder,
                x => $"decimal({x.Precision}, {x.Scale})");
    }
    }
}
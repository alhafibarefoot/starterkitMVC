using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace StarterKitAspNetCoreWebApp.CustomConnventions
{
    public class CustomDataTypeAttributeConvention
    {
        public static void Apply(ModelBuilder builder)
    {
        ConventionBehaviors
            .SetTypeForPropertiesWithAttribute<DataTypeAttribute>(builder,
                x => x.CustomDataType);
    }
    }
}
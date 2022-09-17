//referances https://stackoverflow.com/questions/32049742/ef-7-set-initial-default-value-for-datetime-column

using System;

namespace StarterKitAspNetCoreWebApp.CustomAttributes
{

    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public class DecimalPrecisionAttribute:Attribute
    {
        /// <summary>
    /// Specify the precision - the number of digits both left and right of the decimal
    /// </summary>
    public int Precision { get; set; }

    /// <summary>
    /// Specify the scale - the number of digits to the right of the decimal
    /// </summary>
    public int Scale { get; set; }

    /// <summary>
    /// Set the decimal precision of a decimal sql data type
    /// </summary>
    /// <param name="precision">Specify the precision - the number of digits both left and right of the decimal</param>
    /// <param name="scale">Specify the scale - the number of digits to the right of the decimal</param>
    public DecimalPrecisionAttribute(int precision, int scale)
    {
        Precision = precision;
        Scale = scale;
    }

    public DecimalPrecisionAttribute(int[] values)
    {
        Precision = values[0];
        Scale = values[1];
    }
        
    }
}
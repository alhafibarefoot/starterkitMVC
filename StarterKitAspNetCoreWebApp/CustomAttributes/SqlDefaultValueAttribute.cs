//referances https://stackoverflow.com/questions/32049742/ef-7-set-initial-default-value-for-datetime-column

using System;

namespace StarterKitAspNetCoreWebApp.CustomAttributes
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public class SqlDefaultValueAttribute:Attribute
    {
        public string DefaultValue { get; set; }

    /// <summary>
    /// Set a default value defined on the sql server
    /// </summary>
    /// <param name="value">Default value to apply</param>
    public SqlDefaultValueAttribute(string value)
    {
        DefaultValue = value;
    }
    }
}
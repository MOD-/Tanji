using System;
using System.Net;
using System.Globalization;
using System.ComponentModel;

namespace Tanji.Converters
{
    public class RemoteProxyConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(string);
        }
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            try
            {
                var remoteProxy = new WebProxy((string)value);
                return remoteProxy;
            }
            catch { return null; }
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return destinationType == typeof(string);
        }
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            return ((WebProxy)value).Address.Authority;
        }
    }
}
/* Copyright

    GitHub(Source): https://GitHub.com/ArachisH/Tanji

    Habbo Hotel Packet(Logger/Manipulator)
    Copyright (C) 2015 ArachisH

    This program is free software; you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation; either version 2 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License along
    with this program; if not, write to the Free Software Foundation, Inc.,
    51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.

    See License.txt in the project root for license information.
*/

using System;
using System.Linq;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Generic;

namespace Tanji.Converters
{
    public class GamePortsConverter : TypeConverter
    {
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return destinationType == typeof(string);
        }
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            var ports = (ushort[])value;
            return string.Join(", ", ports);
        }

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(string);
        }
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            var portData = (string)value;
            string[] splitPorts = portData.Split(new[] { ',' },
                StringSplitOptions.RemoveEmptyEntries);

            var ports = new List<int>(splitPorts.Length);
            if (!string.IsNullOrWhiteSpace(portData))
            {
                foreach (string portInfo in splitPorts)
                {
                    if (!string.IsNullOrWhiteSpace(portInfo))
                    {
                        string[] ranges = portInfo.Split(new[] { '-' },
                            StringSplitOptions.RemoveEmptyEntries);

                        ushort minPort;
                        if (ushort.TryParse(ranges[0], out minPort))
                        {
                            ports.Add(minPort);
                            minPort++;
                        }

                        if (ranges.Length == 2)
                        {
                            ushort maxPort;
                            if (ushort.TryParse(ranges[1], out maxPort))
                            {
                                if (maxPort > minPort)
                                {
                                    ports.AddRange(Enumerable.Range(
                                        minPort, maxPort - (minPort - 1)));
                                }
                                else if (maxPort == minPort) ports.Add(maxPort);
                            }
                        }
                    }
                }
            }
            return ports.Distinct().Select(i => (ushort)i).ToArray();
        }
    }
}
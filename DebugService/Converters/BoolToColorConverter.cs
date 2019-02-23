﻿/* 
 * This project is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/
 * Any copyright is dedicated to the NominalNimbus.
 * https://github.com/NominalNimbus 
 */

using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace DebugService.Converters
{
    public class BoolToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is bool))
                throw new InvalidCastException("Invalid value type.");

            return (bool) value
                ? new SolidColorBrush(Color.FromArgb(100, 50, 205, 50))
                : new SolidColorBrush(Color.FromArgb(100, 205, 50, 50));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

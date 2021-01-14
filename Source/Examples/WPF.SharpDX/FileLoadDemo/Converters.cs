using Assimp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace FileLoadDemo
{
    public class Vector3DToTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            // Require

            if (value == null)
                return null;

            var vector = (System.Windows.Media.Media3D.Vector3D)value;
            return $"X:{vector.X.ToString("N2")} Y:{vector.Y.ToString("N2")} Z:{vector.Z.ToString("N2")}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null) return null;
            if (value.GetType() == targetType)
            {
                return value;
            }
            return null;
        }
    }

    public class Point3DToTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            // Require

            if (value == null)
                return null;

            var point = (System.Windows.Media.Media3D.Point3D)value;
            return $"X:{point.X.ToString("N2")} Y:{point.Y.ToString("N2")} Z:{point.Z.ToString("N2")}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null) return null;
            if (value.GetType() == targetType)
            {
                return value;
            }
            return null;
        }
    }
}

using System.Globalization;

namespace SfDataGridSample
{
    public class ColorConverter : IValueConverter
    {
        object IValueConverter.Convert(object? value, Type targetType, object? parameter, CultureInfo info)
        {
            if ((bool)value!)
                return Color.FromArgb("bde0fe"); 
            else
                return Colors.Transparent;
        }
        public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}

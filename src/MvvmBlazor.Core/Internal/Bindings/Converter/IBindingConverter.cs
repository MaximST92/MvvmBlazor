using System.Globalization;

namespace MvvmBlazor.Internal.Bindings.Converter;

public interface IBindingConverter
{
    object Convert(object value, Type? targetType = null, object? parameter = null, CultureInfo? culture = null);

    object ConvertBack(object value, Type? targetType = null, object? parameter = null, CultureInfo? culture = null);
}
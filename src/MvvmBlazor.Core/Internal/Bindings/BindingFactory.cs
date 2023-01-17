using MvvmBlazor.Internal.Bindings.Converter;

namespace MvvmBlazor.Internal.Bindings;

internal interface IBindingFactory
{
    IBinding Create(INotifyPropertyChanged source, PropertyInfo propertyInfo, IWeakEventManager weakEventManager);
    IBinding Create(INotifyPropertyChanged source, PropertyInfo propertyInfo, IWeakEventManager weakEventManager, IBindingConverter converter);
}

internal class BindingFactory : IBindingFactory
{
    public IBinding Create(INotifyPropertyChanged source, PropertyInfo propertyInfo, IWeakEventManager weakEventManager)
    {
        return new Binding(source, propertyInfo, weakEventManager);
    }

    public IBinding Create(INotifyPropertyChanged source, PropertyInfo propertyInfo, IWeakEventManager weakEventManager, IBindingConverter converter)
    {
        return new Binding(source, propertyInfo, weakEventManager, converter);
    }
}
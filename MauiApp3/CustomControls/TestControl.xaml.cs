using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp3.CustomControls;

public partial class TestControl : ContentView
{
    public TestControl()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty TextProperty = BindableProperty.Create(
        propertyName: nameof(Text),
        returnType: typeof(string),
        declaringType: typeof(TestControl),
        defaultValue: null,
        defaultBindingMode: BindingMode.TwoWay);


    public string Text
    {

        get => (string)GetValue(TextProperty);
        set
        {
            SetValue(TextProperty, value);
        }
    }
}
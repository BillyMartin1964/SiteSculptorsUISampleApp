using System;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SiteSculptorsUI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DualButtonControl
    {

        public DualButtonControl()
        {
            InitializeComponent();
        }
        
        public static readonly BindableProperty ButtonHeightRequestProperty = BindableProperty.Create(
                nameof(ButtonHeightRequest),
                typeof(double),
                typeof(DualButtonControl),
                defaultValue: 40d,
                propertyChanged: (bindable, oldValue, newValue) =>
                {
                    var control = (DualButtonControl)bindable;
                    control.FrameCornerRadius = (double)newValue * 0.5;
                });

        public double ButtonHeightRequest
        {
            get => (double)GetValue(ButtonHeightRequestProperty);
            set => SetValue(ButtonHeightRequestProperty, value);
        }

        public static readonly BindableProperty FontAttributesProperty = BindableProperty.Create(
            nameof(FontAttributes),
            typeof(FontAttributes),
            typeof(DualButtonControl),
            defaultValue: FontAttributes.None);

        public FontAttributes FontAttributes
        {
            get => (FontAttributes)GetValue(FontAttributesProperty);
            set => SetValue(FontAttributesProperty, value);
        }
    
        public static readonly BindableProperty FontFamilyProperty = BindableProperty.Create(
            nameof(FontFamily),
            typeof(string),
            typeof(DualButtonControl));

        public string FontFamily
        {
            get => (string)GetValue(FontFamilyProperty);
            set => SetValue(FontFamilyProperty, value);
        }

        public static readonly BindableProperty FontSizeProperty = BindableProperty.Create(
                nameof(FontSize),
                typeof(double),
                typeof(DualButtonControl),
                defaultValue: 16d);

        public double FontSize
        {
            get => (double)GetValue(FontSizeProperty);
            set => SetValue(FontSizeProperty, value);
        }  
        
        public static readonly BindableProperty ButtonSpacingProperty = BindableProperty.Create(
                nameof(ButtonSpacing),
                typeof(double),
                typeof(DualButtonControl),
                defaultValue: 10d);

        public double ButtonSpacing
        {
            get => (double)GetValue(ButtonSpacingProperty);
            set => SetValue(ButtonSpacingProperty, value);
        }
        #region Button 1

        public static readonly BindableProperty Button1TextProperty = BindableProperty.Create(
            nameof(Button1Text),
            typeof(string),
            typeof(DualButtonControl));

        public string Button1Text
        {
            get => (string)GetValue(Button1TextProperty);
            set => SetValue(Button1TextProperty, value);
        }

        public static readonly BindableProperty Button1BackgroundColorProperty = BindableProperty.Create(
            nameof(Button1BackgroundColor),
            typeof(Color),
            typeof(DualButtonControl),
            defaultValue: Color.Transparent);

        public Color Button1BackgroundColor
        {
            get => (Color)GetValue(Button1BackgroundColorProperty);
            set => SetValue(Button1BackgroundColorProperty, value);
        }

        public static readonly BindableProperty Button1TextColorProperty = BindableProperty.Create(
            nameof(Button1TextColor),
            typeof(Color),
            typeof(DualButtonControl),
            defaultValue: Color.Black);

        public Color Button1TextColor
        {
            get => (Color)GetValue(Button1TextColorProperty);
            set => SetValue(Button1TextColorProperty, value);
        }

        public event EventHandler Button1Clicked;
        private void Button1_OnClicked(object sender, EventArgs e)
        {
            Button1Clicked?.Invoke(this, e);
        }

        public static readonly BindableProperty Button1CommandProperty = BindableProperty.Create(
            nameof(Button1Command),
            returnType: typeof(ICommand),
        declaringType: typeof(DualButtonControl),
        defaultValue: default(ICommand),
        defaultBindingMode: BindingMode.OneWay);
        public ICommand Button1Command
        {
            get => (ICommand)this.GetValue(Button1CommandProperty);
            set => this.SetValue(Button1CommandProperty, value);
        }

        public static readonly BindableProperty Button1CommandParameterProperty = BindableProperty.Create(
            propertyName: nameof(Button1CommandParameter),
            returnType: typeof(object),
            declaringType: typeof(DualButtonControl),
            defaultValue: default,
            defaultBindingMode: BindingMode.OneWay);

        public object? Button1CommandParameter
        {
            get => (object?)GetValue(Button1CommandParameterProperty);
            set => SetValue(Button1CommandParameterProperty, value);
        }

        public static readonly BindableProperty Button1EnabledProperty = BindableProperty.Create(
            nameof(Button1Enabled),
            typeof(bool),
            typeof(DualButtonControl),
            defaultValue: true);

        public bool Button1Enabled
        {
            get => (bool)GetValue(Button1EnabledProperty);
            set => SetValue(Button1EnabledProperty, value);
        }

        public static readonly BindableProperty Button1PaddingProperty = BindableProperty.Create(
            nameof(Button1Padding),
            typeof(Thickness),
            typeof(DualButtonControl),
            defaultValue: new Thickness(1));

        public Thickness Button1Padding
        {
            get => (Thickness)GetValue(Button1PaddingProperty);
            set => SetValue(Button1PaddingProperty, value);
        }

        #endregion

        #region Button2
        public static readonly BindableProperty Button2TextProperty = BindableProperty.Create(
            nameof(Button2Text),
            typeof(string),
            typeof(DualButtonControl));

        public string Button2Text
        {
            get => (string)GetValue(Button2TextProperty);
            set => SetValue(Button2TextProperty, value);
        }

        public static readonly BindableProperty Button2BackgroundColorProperty = BindableProperty.Create(
            nameof(Button2BackgroundColor),
            typeof(Color),
            typeof(DualButtonControl),
            defaultValue: Color.Transparent);

        public Color Button2BackgroundColor
        {
            get => (Color)GetValue(Button2BackgroundColorProperty);
            set => SetValue(Button2BackgroundColorProperty, value);
        }

        public static readonly BindableProperty Button2TextColorProperty = BindableProperty.Create(
            nameof(Button2TextColor),
            typeof(Color),
            typeof(DualButtonControl),
            defaultValue: Color.Black);

        public Color Button2TextColor
        {
            get => (Color)GetValue(Button2TextColorProperty);
            set => SetValue(Button2TextColorProperty, value);
        }
        
        public event EventHandler Button2Clicked;
        private void Button2_OnClicked(object sender, EventArgs e)
        {
            Button2Clicked?.Invoke(this, e);
        }
        
        public static readonly BindableProperty Button2CommandProperty = BindableProperty.Create(
            nameof(Button2Command),
            returnType: typeof(ICommand),
            declaringType: typeof(DualButtonControl),
            defaultValue: default(ICommand),
            defaultBindingMode: BindingMode.OneWay);
        public ICommand Button2Command
        {
            get => (ICommand)this.GetValue(Button2CommandProperty);
            set => this.SetValue(Button2CommandProperty, value);
        }

        public static readonly BindableProperty Button2CommandParameterProperty = BindableProperty.Create(
            propertyName: nameof(Button2CommandParameter),
            returnType: typeof(object),
            declaringType: typeof(DualButtonControl),
            defaultValue: default,
            defaultBindingMode: BindingMode.OneWay);

        public object? Button2CommandParameter
        {
            get => (object?)GetValue(Button2CommandParameterProperty);
            set => SetValue(Button2CommandParameterProperty, value);
        }

        public static readonly BindableProperty Button2EnabledProperty = BindableProperty.Create(
            nameof(Button2Enabled),
            typeof(bool),
            typeof(DualButtonControl),
            defaultValue: true);

        public bool Button2Enabled
        {
            get => (bool)GetValue(Button2EnabledProperty);
            set => SetValue(Button2EnabledProperty, value);
        }

        public static readonly BindableProperty Button2PaddingProperty = BindableProperty.Create(
            nameof(Button2Padding),
            typeof(Thickness),
            typeof(DualButtonControl),
            defaultValue: new Thickness(1));

        public Thickness Button2Padding
        {
            get => (Thickness)GetValue(Button2PaddingProperty);
            set => SetValue(Button2PaddingProperty, value);
        }

        #endregion
        

        #region Frame

        public static readonly BindableProperty FrameBorderColorProperty = BindableProperty.Create(
            nameof(FrameBorderColor),
            typeof(Color),
            typeof(DualButtonControl),
            defaultValue: null);

        public Color FrameBorderColor
        {
            get => (Color)GetValue(FrameBorderColorProperty);
            set => SetValue(FrameBorderColorProperty, value);
        }

        public static readonly BindableProperty FrameHasShadowProperty = BindableProperty.Create(
            nameof(FrameHasShadow),
            typeof(bool),
            typeof(DualButtonControl),
            defaultValue: false);

        public bool FrameHasShadow
        {
            get => (bool)GetValue(FrameHasShadowProperty);
            set => SetValue(FrameHasShadowProperty, value);
        }

        public static readonly BindableProperty FrameHorizontalOptionsProperty = BindableProperty.Create(
                   nameof(FrameHorizontalOptions),
                   typeof(LayoutOptions),
                   typeof(DualButtonControl),
                   defaultValue: LayoutOptions.Fill);

        public LayoutOptions FrameHorizontalOptions
        {
            get => (LayoutOptions)GetValue(FrameHorizontalOptionsProperty);
            set => SetValue(FrameHorizontalOptionsProperty, value);
        }

        public static readonly BindableProperty FrameVerticalOptionsProperty = BindableProperty.Create(
                   nameof(FrameVerticalOptions),
                   typeof(LayoutOptions),
                   typeof(DualButtonControl),
                   defaultValue: LayoutOptions.Start);

        public LayoutOptions FrameVerticalOptions
        {
            get => (LayoutOptions)GetValue(FrameVerticalOptionsProperty);
            set => SetValue(FrameVerticalOptionsProperty, value);
        }

        public static readonly BindableProperty FrameCornerRadiusProperty = BindableProperty.Create(
            nameof(FrameCornerRadius),
            typeof(double),
            typeof(DualButtonControl),
            defaultValueCreator: bindable => ((DualButtonControl)bindable).ButtonHeightRequest * 0.5);

        public double FrameCornerRadius
        {
            get => (double)GetValue(FrameCornerRadiusProperty);
            set => SetValue(FrameCornerRadiusProperty, value);
        }

        #endregion

    }
}
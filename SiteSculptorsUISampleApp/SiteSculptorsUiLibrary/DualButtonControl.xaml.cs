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
      //  Button1Clicked += (_, _) => Button1Clicked?.Invoke(this, EventArgs.Empty);
        }

        public static readonly BindableProperty ButtonHeightRequestProperty = BindableProperty.Create(
            nameof(ButtonHeightRequest),
            typeof(double),
            typeof(DualButtonControl));

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

       public event EventHandler Button1Clicked = (e, a) => Button1.Clicked?.Invoke(this, EventArgs.Empty);
        private void Button1Clicked(object sender, EventArgs e) => Dismiss(new ChangePasswordDialogResult() { IsCanceled = true });

        //public static readonly BindableProperty Button1ClickedProperty = BindableProperty.Create(nameof(Button1Clicked), typeof(Action), typeof(DualButtonControl), null);
        //public Action Button1Clicked
        //{
        //    get { return (Action)GetValue(Button1ClickedProperty); }
        //    set { SetValue(Button1ClickedProperty, value); }
        //}

        public static readonly BindableProperty Button2ClickedProperty = BindableProperty.Create(nameof(Button2Clicked), typeof(Action), typeof(DualButtonControl), null);
        public Action Button2Clicked
        {
            get { return (Action)GetValue(Button2ClickedProperty); }
            set { SetValue(Button2ClickedProperty, value); }
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            Button1.Clicked += (sender, args) => Button1Clicked?.Invoke();
            Button2.Clicked += (sender, args) => Button2Clicked?.Invoke();
        }

        //public static readonly BindableProperty Button1ClickedCommandProperty = BindableProperty.Create(
        //        nameof(Button1ClickedCommand),
        //        typeof(Command),
        //        typeof(DualButtonControl));

        //public Command Button1ClickedCommand
        //{
        //    get { return (Command)GetValue(Button1ClickedCommandProperty); }
        //    set { SetValue(Button1ClickedCommandProperty, value); }
        //}



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

        //public event EventHandler? Button2Clicked;

        //public static readonly BindableProperty Button2ClickedCommandProperty = BindableProperty.Create(
        //    nameof(Button2ClickedCommand),
        //    typeof(Command),
        //    typeof(DualButtonControl));

        //public Command Button2ClickedCommand
        //{
        //    get { return (Command)GetValue(Button2ClickedCommandProperty); }
        //    set { SetValue(Button2ClickedCommandProperty, value); }
        //}

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


        //public static readonly BindableProperty TappedCommandProperty = BindableProperty.Create(
        //    propertyName: nameof(TappedCommand),
        //    returnType: typeof(Command<(bool leftPressed, bool rightPressed)>),
        //    declaringType: typeof(Button),
        //    defaultValue: default(Command<(bool leftPressed, bool rightPressed)>?),
        //    defaultBindingMode: BindingMode.OneWay,
        //    propertyChanged: (bindable, oldValue, newValue) =>
        //    {
        //        var typedBindable = (DualButtonControl)bindable;

        //        if (newValue is Command<(bool leftPressed, bool rightPressed)> typedNewValue)
        //        {
        //            typedBindable.Left.TappedCommand = typedBindable.LeftTappedCommand;
        //            typedBindable.Right.TappedCommand = typedBindable.RightTappedCommand;
        //        }
        //        else
        //        {
        //            typedBindable.Left.TappedCommand = null;
        //            typedBindable.Right.TappedCommand = null;
        //        }
        //    });

        //public Command<(bool leftPressed, bool rightPressed)>? TappedCommand
        //{
        //    get => (Command<(bool leftPressed, bool rightPressed)>?)GetValue(TappedCommandProperty);
        //    set => SetValue(TappedCommandProperty, value);
        //}

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
            typeof(DualButtonControl));

        public double FrameCornerRadius
        {
            get => (double)GetValue(FrameCornerRadiusProperty);
            set => SetValue(FrameCornerRadiusProperty, value);
        }

        #endregion
        
    }
}
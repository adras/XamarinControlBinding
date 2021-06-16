using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinControlBinding.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LabeledDecimalBox : ContentView
    {
        public static readonly BindableProperty LabelTextProperty = BindableProperty.Create(nameof(LabelText), typeof(string), typeof(LabeledDecimalBox), defaultValue: string.Empty, defaultBindingMode: BindingMode.TwoWay, propertyChanged: LabelTextPropertyChanged);

        // Important, for these Bindings we need BindingMode.TwoWay, otherwise the model won't be updated when the entries text changes
        public static readonly BindableProperty EntryValueProperty = BindableProperty.Create(nameof(EntryValue), typeof(decimal), typeof(LabeledDecimalBox), defaultValue: decimal.Zero, defaultBindingMode: BindingMode.TwoWay, propertyChanged: EntryValuePropertyChanged);

        public decimal EntryValue
        {
            get
            {
                return (decimal)base.GetValue(EntryValueProperty);
            }
            set
            {
                base.SetValue(EntryValueProperty, value);
            }
        }

        public string LabelText
        {
            get
            {
                return (string)base.GetValue(LabelTextProperty);
            }
            set
            {
                base.SetValue(LabelTextProperty, value);
            }
        }
        
        public LabeledDecimalBox()
        {
            InitializeComponent();

            // Important, otherwise the binding on the Text properties of the Label and Entry won't work
            Label.BindingContext = this;
            Entry.BindingContext = this;
        }

        private static void LabelTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            LabeledDecimalBox control = (LabeledDecimalBox)bindable;
            control.Label.Text = (string)newValue;
        }

        private static void EntryValuePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            LabeledDecimalBox control = (LabeledDecimalBox)bindable;
            control.Entry.Text = ((decimal)newValue).ToString();
        }


    }
}
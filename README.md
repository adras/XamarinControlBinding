# XamarinControlBinding
Example of Databinding of Custom Properties in a Custom Control

It features a custom control which has a label and a TextBox/Entry field. Very useful when you want a TextBox/Entry that also comes with a label.

# Controls folder contains the custom Control
The custom control is LabeledDecimalBox, it contains a label and a TextBox/Entry to enter a value. The control has two properties which can be set:

* LabelText is the text the label should contain
* EntryText is the text the TextBox/Entry should contain. Usually you use databinding to bind the entered value to your model

# MainPageViewModel
The ViewModel of the mainpage. It has two fields, one for the "Soll/Expected" value and one for the "Ist/Actual" value. It also comes with a difference property which is automatically calculated from the "Soll" and "Ist" values.

# MainPage

The MainPage uses the control three times, here's an example of one of the usages:

```
<ctrl:LabeledDecimalBox LabelText="Expected Value:" EntryValue="{Binding Soll, Mode=TwoWay}"></ctrl:LabeledDecimalBox>
```

The LabelText of the control is set to a fixed value (Databinding also possible), and EntryValue is databound to a property in the MainPageModel. Whenever the text in the TextBox/Entry of the control is changed the model is automatically updated and vice-versa.


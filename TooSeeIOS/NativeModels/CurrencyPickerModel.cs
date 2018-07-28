using System;
using UIKit;

public class CurrencyPickerModel : UIPickerViewModel
{
    public string[] currencies = new string[] {
            "USD",
            "UAH",
            "RUB"
        };

    private UILabel currencyValueLabel;

    public CurrencyPickerModel(UILabel currencyValueLabel)
    {
        this.currencyValueLabel = currencyValueLabel;
    }

    public override nint GetComponentCount(UIPickerView pickerView)
    {
        return 1;
    }

    public override nint GetRowsInComponent(UIPickerView pickerView, nint component)
    {
        return currencies.Length;
    }

    public override string GetTitle(UIPickerView pickerView, nint row, nint component)
    {
        if (component == 0)
            return currencies[row];
        else
            return row.ToString();
    }

    public override void Selected(UIPickerView pickerView, nint row, nint component)
    {
        currencyValueLabel.Text = currencies[pickerView.SelectedRowInComponent(0)];
    }
}

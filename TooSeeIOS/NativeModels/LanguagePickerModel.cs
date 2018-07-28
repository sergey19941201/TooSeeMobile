using System;
using UIKit;

namespace TooSeeIOS.NativeModels
{
    public class LanguagePickerModel: UIPickerViewModel
    {
        public string[] languages = new string[] {
            "Русский",
            "English",
            "Italiano",
            "Украинский",
            "Deutsch"
        };

        private UILabel languageValueLabel;

        public LanguagePickerModel(UILabel currencyValueLabel)
        {
            this.languageValueLabel = currencyValueLabel;
        }

        public override nint GetComponentCount(UIPickerView pickerView)
        {
            return 1;
        }

        public override nint GetRowsInComponent(UIPickerView pickerView, nint component)
        {
            return languages.Length;
        }

        public override string GetTitle(UIPickerView pickerView, nint row, nint component)
        {
            if (component == 0)
                return languages[row];
            else
                return row.ToString();
        }

        public override void Selected(UIPickerView pickerView, nint row, nint component)
        {
            languageValueLabel.Text = languages[pickerView.SelectedRowInComponent(0)];
        }
    }
}

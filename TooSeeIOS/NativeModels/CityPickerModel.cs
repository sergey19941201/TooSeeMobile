using System;
using UIKit;

namespace TooSeeIOS.NativeModels
{
    public class CityPickerModel: UIPickerViewModel
    {
        public string[] cities = new string[] {
            "Washington",
            "Жмеринка",
            "Ладыжин",
            "Козятин",
            "Ливерпуль",
            "Лондон",
        };

        private UILabel cityValueLabel;

        public CityPickerModel(UILabel currencyValueLabel)
        {
            this.cityValueLabel = currencyValueLabel;
        }

        public override nint GetComponentCount(UIPickerView pickerView)
        {
            return 1;
        }

        public override nint GetRowsInComponent(UIPickerView pickerView, nint component)
        {
            return cities.Length;
        }

        public override string GetTitle(UIPickerView pickerView, nint row, nint component)
        {
            if (component == 0)
                return cities[row];
            else
                return row.ToString();
        }

        public override void Selected(UIPickerView pickerView, nint row, nint component)
        {
            cityValueLabel.Text = cities[pickerView.SelectedRowInComponent(0)];
        }
    }
}

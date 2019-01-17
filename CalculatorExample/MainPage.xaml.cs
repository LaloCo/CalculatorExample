using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculatorExample
{
    public partial class MainPage : ContentPage
    {
        private bool isDecimal = false;
        public MainPage()
        {
            InitializeComponent();

            Xamarin.Forms.PlatformConfiguration.iOSSpecific.Page.SetUseSafeArea(this, true);
        }

        private void NumberButton_Clicked(object sender, EventArgs args)
        {
            string currentNumber = resultLabel.Text;
            string number = (sender as Button).Text;
            if (!isDecimal)
            {
                string newNumber = $"{currentNumber}{number}";
                float result;
                if (float.TryParse(newNumber, out result))
                    resultLabel.Text = result.ToString();
            }
            else
            {
                string newNumber = $"{currentNumber}.{number}";
                float result;
                if (float.TryParse(newNumber, out result))
                    resultLabel.Text = result.ToString();
                isDecimal = false;
            }
        }

        private void DecimalButton_Clicked(object sender, EventArgs args)
        {
            isDecimal = true;
        }
    }
}

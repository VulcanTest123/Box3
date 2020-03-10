using System;
using System.Collections.Generic;
using Xamarin.Forms;


namespace Box3
{
    public partial class FiboPage : ContentPage
    {
        public FiboPage()
        {
                InitializeComponent();
        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            Byte value = Convert.ToByte(args.NewValue);
            zahl.Text = Convert.ToString(value);
            Byte fibozahl=0;
            Byte[] fibarr = new byte[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144,233 };

            if (value == 1 || value == 2)
            {
                fibozahl = 1;
            }
            if (value == 12)
            {
                fibozahl = 100;
            }
            else {
                fibozahl = fibarr[value-1];
            }
            fibo.Text = Convert.ToString(fibozahl);
            
        }
    }
}

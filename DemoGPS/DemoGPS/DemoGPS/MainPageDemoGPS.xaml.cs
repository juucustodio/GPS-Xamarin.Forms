using Plugin.Geolocator;
using System;
using Xamarin.Forms;

namespace DemoGPS
{
    public partial class MainPageDemoGPS : ContentPage
    {
        public MainPageDemoGPS()
        {
            InitializeComponent();
        }

        private async void GetPosition(object sender, EventArgs e)
        {
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 50;

            var position = await locator.GetPositionAsync(TimeSpan.FromSeconds(10));

            LongitudeLabel.Text = string.Format("{0:0.0000000}", position.Longitude); 
            LatitudeLabel.Text = string.Format("{0:0.0000000}", position.Latitude); 
        }
    }
}

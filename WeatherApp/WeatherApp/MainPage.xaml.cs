using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WeatherApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }
        public List<Weather> Weathers { get => WeatherData(); }

        private List<Weather> WeatherData()
        {
            var tmpList = new List<Weather>();

            tmpList.Add(new Weather { Temp = "22", Date = "Sunday 16", Icon = "weather.png" });
            tmpList.Add(new Weather { Temp = "21", Date = "Monday 16", Icon = "weather.png" });

            tmpList.Add(new Weather { Temp = "20", Date = "Tuesday 16", Icon = "weather.png" });

            tmpList.Add(new Weather { Temp = "12", Date = "Wednesday 16", Icon = "weather.png" });

            tmpList.Add(new Weather { Temp = "22", Date = "Thrusday 20", Icon = "weather.png" });

            tmpList.Add(new Weather { Temp = "17", Date = "Friday 21", Icon = "weather.png" });
            tmpList.Add(new Weather { Temp = "20", Date = "Saturday 16", Icon = "weather.png" });

            return tmpList;
        }
    }

    public class Weather
    {
        public string Temp { get; set; }

        public string Date { get; set; }

        public string Icon { get; set; }
    }
}

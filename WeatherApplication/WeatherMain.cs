using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WeatherApplication
{
    public partial class WeatherMain : Form
    {
        ApiConf apiConf = new ApiConf();

        public WeatherMain()
        {
            InitializeComponent();

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchBox();
        }

        private void SearchBox()
        {
            string city = textBoxSearch.Text;
            var weatherMap = apiConf.ApiCall(city);
            var localTemp = weatherMap.main.temp;
            var feelsLike = weatherMap.main.feels_like;
            var minTemp = weatherMap.main.temp_min;
            var maxTemp = weatherMap.main.temp_max;
            var humidity = weatherMap.main.humidity;
            var list = weatherMap.weather[0].description.ToString();

            labelList.Text = list;

            var minTempRound = Math.Round(minTemp, 0).ToString();
            labelMinTemp.Text = minTempRound + " °C";

            var maxTempRound = Math.Round(maxTemp, 0).ToString();
            labelMaxTemp.Text = maxTempRound + " °C";

            var humidityRound = humidity.ToString();
            labelHumidity.Text = humidityRound + " %";

            var tempRound = Math.Round(localTemp, 0).ToString();
            labelTemp.Text = tempRound + " °C";

            var feelsLikeRound = Math.Round(feelsLike, 0).ToString();
            labelFeelsLike.Text = feelsLikeRound + " °C";
        }
    }
}

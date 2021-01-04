using Newtonsoft.Json;
using System.Net;

namespace smart_wardrobe.Data {
    public class WeatherAPI {

        private const string APIKEY = "80c98f42629f6d9a7dcd6b6c38f9cd6b";
        private string _weatherURL;
        private string _baseURL = "https://api.openweathermap.org";
        public WeatherAPI(string city) {
            SetCurrentURL(city);
        }

        private void SetCurrentURL(string city) {
            _weatherURL = _baseURL + "/data/2.5/weather?q="
                + city + "&appid=" + APIKEY + "&units=metric";
        }
        public string GetImgUrl(string code) => "http://openweathermap.org/img/wn/" + code + "@2x.png";

        public Weather FetchData() {
            using (var webClient = new WebClient()) {
                var res = webClient.DownloadString(_weatherURL);
                var weather =
                 JsonConvert.DeserializeObject<Weather>(res);
                return weather;
            }
        }
    }
}

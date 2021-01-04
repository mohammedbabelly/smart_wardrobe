using Prolog;
using smart_wardrobe.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace smart_wardrobe {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            Console.WriteLine("test");
            GetWeather();
            ExcuteProlog();
        }

        public void ExcuteProlog() {
            var prolog = new PrologEngine(persistentCommandHistory: false);
            var query = "findOutfits(15,male,clear_day,Outfits).";
            var solution2 = prolog.GetAllSolutions(AppDomain.CurrentDomain.BaseDirectory + "/Assets/prolog/outfits.pl", query);
            foreach (var d in solution2.NextSolution) {
                foreach (var s in d.NextVariable) {
                    Console.WriteLine(s.Value);
                }
            }
        }
        public Weather GetWeather() {
            Weather weather = new WeatherAPI("Aleppo").FetchData();
            Console.WriteLine(weather.main.temp);
            Console.WriteLine(weather.weather.First().description);
            return weather;
        }
    }
}

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
            

        }
        private List<string> paths = new List<string>();
        private Weather weather;
        string sex ;

        public List<string > ExcuteProlog() {
            var prolog = new PrologEngine(persistentCommandHistory: false);
            if (rdbm.IsChecked == true) sex = "female";
            else sex = "male";
            var query = "findOutfits("+ weather.main.temp + "," +sex+",clear_day,Outfits).";
            //  var query = "findOutfits( 15 ,male + ,clear_day,Outfits).";
            var solution2 = prolog.GetAllSolutions(AppDomain.CurrentDomain.BaseDirectory + "Assets/prolog/outfits.pl", query);
            foreach (var d in solution2.NextSolution) {
                foreach (var s in d.NextVariable) {
                     paths.Add(s.Value);
                }
            }
            return paths;
                }
        public Weather GetWeather() {
            Weather weather = new WeatherAPI(txtcity.Text).FetchData();
            Console.WriteLine();
            Console.WriteLine(weather.weather.First().description);
            return weather;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            weather = new WeatherAPI(txtcity.Text).FetchData();
            ExcuteProlog();
            Main.Content = new face( paths, weather.main.temp , txtcity.Text);
        }
           

        
    }
}

using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var client = new RestClient("https://api.collectapi.com/corona/countriesData");
            client.UseNewtonsoftJson();
            var request = new RestRequest(Method.GET);
            request.AddHeader("authorization", "apikey replaceme");
            request.AddHeader("content-type", "application/json");

            var results = client.Execute<CountriesDataPOCO.Rootobject>(request);
            var records = results.Data;

            Country.Text = records.result.First().country;
            Confirmed.Text = records.result.First().activeCases;
            Death.Text = records.result.First().totalDeaths;
            Recovered.Text = records.result.First().totalRecovered;

        }
    }
}

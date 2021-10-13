using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.Json;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Text.Json;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace currencyRates
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            window_for_tests.Text = "ddd";

            var json = new WebClient().DownloadString("https://www.cbr-xml-daily.ru/daily_json.js");

            // JSON has the logic like { “key”: “value” } statement.
            //Т.е. json - это:
            //ключ -> значение(оно тоже м.б. ключом) -> значение(оно тоже м.б. ключом) и т.д.
           var vr = json.Length;
            //window_for_tests.Text = json;

            JsonDocument doc = JsonDocument.Parse(json);
            JsonElement root = doc.RootElement;
            window_for_tests.Text = root.GetProperty("Valute").GetProperty("USD") .ToString();
            //Console.WriteLine(root);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }
    }
}

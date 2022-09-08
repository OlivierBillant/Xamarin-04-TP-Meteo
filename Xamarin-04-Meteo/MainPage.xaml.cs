using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using RestSharp;
using RestSharp.Authenticators;
using Xamarin.Forms.Shapes;
using Xamarin_04_Meteo.Models;
using Xamarin_04_Meteo.Utils;

namespace Xamarin_04_Meteo
{
    public partial class MainPage : ContentPage
    {
        public string ville = "Quimper";


        public MainPage()
        {
            InitializeComponent();
        }

        private async void button_ok_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(inputVille.Text))
            {
                await DisplayAlert("Erreur", "Vous devez saisir une ville", "Retour");
                return;
            }
            /*var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                await DisplayAlert("Bravo", "Vous avez accès à l'internet", "Retour");
            }
*/
            //Appel API
            //On instancie le sevirce.
            var meteoService = new MeteoService();
            var meteo = await meteoService.CurrentWeather(inputVille.Text);

            if (meteo.Cod == 200)
            {
                //await DisplayAlert("Bravo", "Vous aurez bientôt la météo de votre ville", "Retour");
                label_city.Text = meteo.Name;
                label_temp.Text = $"{Convert.ToString(meteo.Main.temp)}°C";
                image_meteo.Source = $"{Constant.iconCall}{meteo.Weather[0].icon}@2x.png";
            }
            else
            {
                await DisplayAlert("Erreur", meteo.Message, "Retour");
            }

        }

        private void button_secondPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2("prenom"));
        }




    }
}

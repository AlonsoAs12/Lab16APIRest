using Lab16APIRest.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab16APIRest
{
    public partial class MainPage : ContentPage
    {
        private string url = "https://jsonplaceholder.typicode.com/todos";
        HttpClient cliente = new HttpClient();
        public MainPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            string contenido = await cliente.GetStringAsync(url);
            IEnumerable<UsuarioModel> lista = JsonConvert.DeserializeObject<IEnumerable<UsuarioModel>>(contenido);
            lusuario.ItemsSource = new ObservableCollection<UsuarioModel>(lista);
            base.OnAppearing();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewExercicios
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Exercicio02 : ContentPage
    {
        public Exercicio02()
        {
            InitializeComponent();

            var frutas = new List<String>
            {
                "Abacate",
                "Abacaxi",
                "Banana",
                "Caju",
                "Figo",
                "Goiaba",
                "Laranja",
                "Melancia",
                "Pêssego",
                "Tangerina"
            };

            var listView = new ListView
            {
                ItemsSource = frutas
            };

            Content = listView;

            listView.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
            {
                var fruta = (String) e.SelectedItem;

                DisplayAlert("Item Selecionado", fruta.ToString(), "OK");
            };
        }
    }
}
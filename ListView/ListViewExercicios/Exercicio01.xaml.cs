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
    public partial class Exercicio01 : ContentPage
    {
        public Exercicio01()
        {
            InitializeComponent();

            var lstFrutas = new List<String>
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

            lstView.ItemsSource = lstFrutas;
        }

        private void LstView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var frutas = e.SelectedItem as String;
            DisplayAlert("Item Selecionado", frutas.ToString(), "OK");
        }
    }
}
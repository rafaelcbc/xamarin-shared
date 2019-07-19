using ListViewExercicios.Models;
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
    public partial class Exercicio03 : ContentPage
    {
        public Exercicio03()
        {
            InitializeComponent();

            var produto = new Produto();

            listview.ItemsSource = produto.GetProdutos();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace ListViewExercicios.Models
{
    public class Produto
    {
        public string Nome { get; set; }
        public string Preco { get; set; }
        public string Imagem { get; set; }

        public List<Produto> GetProdutos()
        {
            return new List<Produto>
            {
                new Produto {
                    Nome ="Câmera",
                    Preco ="R$ 269,00",
                    Imagem ="http://macoratti.net/Imagens/produtos/camera64.jpg" },
                new Produto {
                    Nome ="Tablet",
                    Preco ="R$ 367,50",
                    Imagem ="http://macoratti.net/Imagens/produtos/tablet64.jpg" },
                new Produto {
                    Nome ="Celular",
                    Preco="R$ 564,00",
                    Imagem ="http://macoratti.net/Imagens/produtos/celular64.jpg" },
                new Produto {
                    Nome ="iPhone S",
                    Preco ="R$ 1962,00",
                    Imagem ="http://macoratti.net/Imagens/produtos/iphone64.jpg" }
            };
        }
    }
}

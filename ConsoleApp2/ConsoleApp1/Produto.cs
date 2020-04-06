using System.Globalization;

namespace ConsoleApp1
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public Produto(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = 10;
        }
        public Produto(double preco)
        {
            Preco = preco;
            _nome = "sem nome";
            Quantidade = 1;
        }
        public string Nome { 
            get { return _nome; } 
            set {
                if (value == " " || value.Length <= 1)
                {
                    System.Console.WriteLine("Nome não permitido!");
                }
                else
                {
                    _nome = value;
                }
            } 
        }         
        public double ValorTotalEmEstoque()
        {
            return  Preco * Quantidade;
        }
        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome + ", $" + Preco.ToString("F2", CultureInfo.InvariantCulture)+", "+Quantidade+" unidades, "
                +"total $"+ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture);
        }        
        
    }
}

using ConsoleApp1.Utilities;

namespace ConsoleApp1
{
    internal class Produto
    {
        static private List<Produto> produtos = new List<Produto>();
        private int code;
        private string name;
        private decimal price_brought;
        private decimal price_sell;
        private bool active;
        private DateTime? date_registry;
        private string desc;

        public Produto(int code, string name, decimal price_brought, decimal price_sell,bool active, DateTime date_registry, string desc)
        {
            this.code = code;
            this.name = name;
            this.desc = desc;
            this.price_brought = price_brought;
            this.price_sell = price_sell;
            this.active = active;
            this.date_registry = date_registry;
        }

        public int Code { get { return this.code;  } }

        public void InsertProduct(Produto produto)
        {
            produtos.Add(produto);
        }

        public void Change(Produto produto)
        {
            this.code = produto.code;
            this.name = produto.name;
            this.desc = produto.desc;
            this.price_brought = produto.price_brought;
            this.price_sell = produto.price_sell;
            this.active = produto.active;
            this.date_registry = produto.date_registry;
        }

        public Produto SearchProduct(int code)
        {
            foreach (Produto produto in produtos)
            {
                if (produto.code == code)
                {
                    return produto;
                }
            }
            return null;
        }

        public void Exclude(int code)
        {
            produtos = produtos.Where(prod => prod.code != code).ToList();
        }

        public void PrintOneProduct(Produto produto)
        {
            Console.WriteLine("\n=================****=================\n" +
                              $"Codigo: {produto.code}\nNome: {produto.name}\nDescrição: {produto.desc}\n" +
                              $"Preço Compra: R${produto.price_brought}\nPreço Venda: R${produto.price_sell}\n" +
                              $"Ativo: {produto.active}\nRegistrado em: {produto.date_registry}\n" +
                              "=================****=================\n\n");
        }

        public void PrintAllProducts()
        {
            Console.WriteLine();
            foreach (Produto produto in produtos)
            {
                produto.PrintOneProduct(produto);
            }
        }
    }
}

namespace ConsoleApp2
{
    internal class Produto
    {
        static private List<Produto> produtos = new List<Produto>();
        private int code = -1;
<<<<<<< HEAD
        private string name =  " ";
=======
        private string name = " ";
>>>>>>> cac31cf11a5dc2505a910d20ca615ba3ca15cc52
        private decimal price_brought;
        private decimal price_sell;
        private bool active;
        private DateTime date_registry;
        private string desc = " ";

<<<<<<< HEAD
        public int Code { get{ return this.code; } 
                          set{ this.code = value; } }
        public string Name { get { return IsNullString(this.name); } 
                             set { this.name =  IsNullString(value); } }
        public decimal Price_brought { get{ return this.price_brought; } 
                          set{ this.price_brought = value; } }
        public decimal Price_sell { get{ return this.price_sell; } 
                          set{ this.price_sell = value; } }
        public bool Active { get{ return this.active; } 
                          set{ this.active = value; } }
        public DateTime? Date_registry { get{ return this.date_registry; } 
                          set{ this.date_registry = new DateTime(1970, 01, 01); } }   
        public string Desc { get { return IsNullString(this.desc); }
                             set { this.desc =  IsNullString(value); }  }

        public string IsNullString(string value)
        {
            if(value == null || value == "")
            {
                return "";
            }
            else
            {
                return value;
            }
        }

=======
        public int Code
        {
            get { return this.code; }
            set { this.code = value; }
        }
        public string Name
        {
            get { return IsNullString(this.name); }
            set { this.name = IsNullString(value); }
        }
        public decimal Price_brought
        {
            get { return this.price_brought; }
            set { this.price_brought = value; }
        }
        public decimal Price_sell
        {
            get { return this.price_sell; }
            set { this.price_sell = value; }
        }
        public bool Active
        {
            get { return this.active; }
            set { this.active = value; }
        }
        public DateTime? Date_registry
        {
            get { return this.date_registry; }
            set { this.date_registry = new DateTime(1970, 01, 01); }
        }
        public string Desc
        {
            get { return IsNullString(this.desc); }
            set { this.desc = IsNullString(value); }
        }

        public string IsNullString(string value)
        {
            if (value == null || value == "")
            {
                return "";
            }
            else
            {
                return value;
            }
        }

>>>>>>> cac31cf11a5dc2505a910d20ca615ba3ca15cc52
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

        public Produto TakeOneFromList(int code)
        {
            int ProdutoIndx = SearchProduct(code);
            return ProdutoIndx != -1 ? produtos[ProdutoIndx] : new();
        }

        private int SearchProduct(int code)
        {
            foreach (Produto produto in produtos)
            {
                if (produto.code == code)
                {
                    return produtos.IndexOf(produto);
                }
            }
            return -1;
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

var list = new List<Produtos>();
list = Produtos.GetProdutos();
int itensPerPage = 2;
int pageNumber = 3;

// pagination with chunk method (only .NET6)
IEnumerable<Produtos[]> allProducts = list.Chunk(itensPerPage);

Console.WriteLine($"page number: {pageNumber}");

var paginatedResult = allProducts.ElementAt(pageNumber - 1);

foreach (var item in paginatedResult)
{
    Console.WriteLine($"{item.id} - {item.nome}");
}

internal class Produtos
{
    public int id { get; set; }
    public string nome { get; set; }

    public static List<Produtos> GetProdutos()
    {
        var list = new List<Produtos>() {
            new Produtos() { id = 1, nome = "caneta" },
            new Produtos() { id = 2, nome = "caneta2" },
            new Produtos() { id = 3, nome = "caneta3" },
            new Produtos() { id = 4, nome = "caneta4" },
            new Produtos() { id = 5, nome = "caneta5" },
            new Produtos() { id = 6, nome = "caneta6" },
            new Produtos() { id = 7, nome = "caneta7" },
            new Produtos() { id = 8, nome = "caneta8" },
            new Produtos() { id = 9, nome = "caneta9" }
        };

        return list;
    }
}
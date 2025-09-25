using System.IO.Compression;
using System.Runtime.InteropServices;

class Produto
{
    private string _Nome;
    public string Nome
    {
        get { return _Nome; }
        set { _Nome = value; }
    }
    private int _CategoriaProd;
    public int CategoriaProd
    {
        get { return _CategoriaProd; }
        set { _CategoriaProd = value; }
    }

    public CodCat Categoria;
    private int _Preco;
    public int Preco
    {
        get { return _Preco; }
        set { _Preco = value; }
    }
    private int _Estoque;
    public int Estoque
    {
        get { return _Estoque; }
        set { _Estoque = value; }
    }


    public Produto IncluirProduto()
    {
        Produto xProduto = new Produto();
        System.Console.WriteLine("Insira o nome do novo produto");
        xProduto._Nome = Console.ReadLine();
        System.Console.WriteLine("Insira o código da categoria ");
        xProduto._CategoriaProd = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Insira o preço do produto");
        xProduto._Preco = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Insira a quantidade de estoque");
        xProduto._Estoque = int.Parse(Console.ReadLine());

        return xProduto;
    }
    public void Relatorio()
    {
        CodCat cat = new CodCat();
        System.Console.WriteLine("Produto: " + _Nome);
        System.Console.WriteLine("Código da Categoria: " + cat.Codigo[_CategoriaProd - 1]);
        System.Console.WriteLine("Descrição da Categoria: " + cat.Descricao[_CategoriaProd - 1]);
        System.Console.WriteLine("Preço: " + _Preco);
        System.Console.WriteLine("Estoque: " + _Estoque);
    }

    public int Inventario()
    {
        return _Preco * _Estoque;
    }
}
class CodCat
{
    public int[] Codigo = { 1, 2, 3, 4 };
    public string[] Descricao = { "Produto de Limpeza", "Padaria e Confeitaria", "Frios e Laticínios", "Bebidas" };
}
class Program
{
    static void Main()
    {
        Produto[] CadProd = new Produto[10];
        int ind = 0, inventario = 0;
        string fim = "s";
        do
        {
            Produto xProduto = new Produto();
            CadProd[ind] = xProduto.IncluirProduto();
            ind++;

            System.Console.WriteLine("Deseja inserir outro? ('n' para sair)");
            fim = Console.ReadLine();
        } while (fim != "n");

        for (int i = 0; i < ind; i++)
        {
            CadProd[i].Relatorio();
        }
        for (int i = 0; i < ind; i++)
        {
            inventario += CadProd[i].Inventario();
        }

        System.Console.WriteLine($"Em inventário, há o valor total de R${inventario}");
    }

}
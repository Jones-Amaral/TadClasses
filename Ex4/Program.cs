using System.ComponentModel;

class Filmes
{
    private string _Nome;
    public string Nome
    {
        get { return _Nome; }
        set { _Nome = value; }
    }
    private int _Duracao;
    public int Duracao
    {
        get { return _Duracao; }
        set { _Duracao = value; }
    }
    private string _Diretor;
    public string Diretor
    {
        get { return _Diretor; }
        set { _Diretor = value; }
    }
    private string _Categoria;
    public string Categoria
    {
        get { return _Categoria; }
        set { _Categoria = value; }
    }

    public void FilmesCadastrados()
    {
        System.Console.WriteLine("Filme: " + _Nome);
        System.Console.WriteLine("Duração: " + _Duracao);
        System.Console.WriteLine("Diretor: " + _Diretor);
        System.Console.WriteLine("Categoria: " + _Categoria);
        System.Console.WriteLine("-------------------------------");
    }

    public void CategoriaFilmes(string cat)
    {
        if (cat == _Categoria)
            System.Console.WriteLine(_Nome);
    }
}

class Program
{
    static void Main()
    {
        Filmes[] Filme = new Filmes[5];
        string cat;
        for (int i = 0; i < 5; i++)
        {
            Filmes xFilme = new Filmes();

            System.Console.WriteLine("Insira o título do filme " + (i + 1));
            xFilme.Nome = Console.ReadLine();
            System.Console.WriteLine("Insira a duração do filme " + (i + 1));
            xFilme.Duracao = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Insira o diretor do filme " + (i + 1));
            xFilme.Diretor = Console.ReadLine();
            System.Console.WriteLine("Insira a categoria do filme " + (i + 1));
            xFilme.Categoria = Console.ReadLine();
            Filme[i] = xFilme;

        }
        for (int i = 0; i < 5; i++)
        {
            Filme[i].FilmesCadastrados();
        }
        System.Console.WriteLine("Insira a categoria que deseja listar");
        cat = Console.ReadLine();
        for (int i = 0; i < 5; i++)
        {
            Filme[i].CategoriaFilmes(cat);
        }
    }
}
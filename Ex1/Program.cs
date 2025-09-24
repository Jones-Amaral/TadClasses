class Aluno
{
    private string _Nome;
    public string Nome
    {
        get { return _Nome; }
        set { _Nome = value; }
    }
    private string _Email;
    public string Email
    {
        get { return _Email; }
        set { _Email = value; }
    }
    private string _DataNascimento;
    public string DataNascimento
    {
        get { return _DataNascimento; }
        set { _DataNascimento = value; }
    }
    private string _Telefone;
    public string Telefone
    {
        get { return _Telefone; }
        set { _Telefone = value; }
    }
    public void MostraAluno()
    {
        System.Console.WriteLine("Nome do Aluno: " + _Nome);
        System.Console.WriteLine("Email: " + _Email);
        System.Console.WriteLine("Data de Nascimento: " + _DataNascimento);
        System.Console.WriteLine("Telefone: " + _Telefone);
    }
}
class Program
{
    static void Main()
    {
        Aluno cadAluno = new Aluno();
        System.Console.WriteLine("Insira o nome do aluno ");
        cadAluno.Nome = Console.ReadLine();
        System.Console.WriteLine("Insira o email do aluno ");
        cadAluno.Email = Console.ReadLine();
        System.Console.WriteLine("Insira o telefone do aluno ");
        cadAluno.Telefone = Console.ReadLine();
        System.Console.WriteLine("Insira a data de nascimento do aluno ");
        cadAluno.DataNascimento = Console.ReadLine();

        cadAluno.MostraAluno();
    }
}
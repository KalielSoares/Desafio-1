using Produto.Models;

namespace Produto;

public class Program
{
    static void Main(string[] args)
    {
        var Caderno = new produtos("Caderno", 15);
        Console.WriteLine(Caderno.GetData());
        
        Caderno.ChangeValue(-12);
        Console.WriteLine(Caderno.GetData());
        
        Caderno.ChangeValue(20);
        Console.WriteLine(Caderno.GetData());
    }
}
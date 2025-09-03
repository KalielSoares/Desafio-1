namespace Produto.Models;

public class produtos
{
    private string _Nome { get; set; }
    private int _Value = 15;

    public produtos(string Nome, int Value)
    {
        _Nome = Nome;
        _Value = Value;
    }

    public void ChangeValue(int n)
    {
        if (n > 0)
        {
            _Value = n;
            Console.WriteLine("Valor alterado");
        }
        else
            Console.WriteLine("Valor inferior a 0");
    }

    public string GetData()
    {
        return $"Produto:{_Nome}, Preço:{_Value}";
    }
}
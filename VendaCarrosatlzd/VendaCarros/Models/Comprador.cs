namespace VendaCarros.Models;
public class Comprador
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string CPF { get; set; }    
    public string Modelo { get; set; }
    public double Valor { get; set; }
    public string Endereco { get; set; }

    public Comprador() { }

    public Comprador(int id, string nome, string cpf, string modelo, double valor, string endereco)
    {
        Id = id;
        Nome = nome;
        CPF = cpf;
        Modelo = modelo;
        Valor = valor;
        Endereco = endereco;
    }
}
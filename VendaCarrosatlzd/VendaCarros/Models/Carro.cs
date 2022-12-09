namespace VendaCarros.Models;
public class Carro
{
    public int Id { get; set; }
    public string Modelo { get; set; }
    public int Placa { get; set; }
    public int Ano { get; set; }
    public string Marca { get; set; }

    public Carro() { }

    public Carro(int id, string modelo, int placa, int ano, string marca)
    {
        Id = id;
        Modelo = modelo;
        Placa = placa;
        Ano = ano;
        Marca = marca;
    }
}
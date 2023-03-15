// See https://aka.ms/new-console-template for more information
using ConsoleApp_Manhã;

Console.WriteLine("Hello, World!");

//Produto p1 = new Produto(1, "Mouse sem fio", 59.90m);
//Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

// !! Set = alterar valor de um objeto, atribuir parametro !!

//Pessoa pessoa1 = new Pessoa(1, "Eduardo Del Vecchio", "993213904");
//Console.WriteLine("Nome:" + pessoa1.getNome() + " Telefone:" + pessoa1.getTelefone());

Endereco e1 = new Endereco("Antonio Costa Mendonça", "295", "15902112", "Jardim Pagliuso", "Taquaritinga", "SP");

Cliente c1 = new Cliente(1, "Eduardo", "993213904", e1);
Cliente c2 = new Cliente(2, "Mariana", "997780181", e1);
Cliente c3 = new Cliente(3, "Sabrina", "993278759", e1);
Cliente c4 = new Cliente(4, "Francisco", "993552305", e1);

Console.WriteLine(c1.getEndereco().getRua());
c1.getEndereco().setRua("Grisso Lupi");
Console.WriteLine(c1.getEndereco().getRua());

Carro car = new Carro();
car.Marca = "VW";
car.numeroPortas = 4;
car.numeroRodas = 4;
car.cor = "Vermelho";


Avião aviao = new Avião();
aviao.portasInternas = 50;
aviao.numeroPortas = 1;
aviao.numeroRodas = 3;
aviao.cor = "Branco";
aviao.quantidadeAcento = 500;
aviao.PagaImposto = false;

Bike bicicleta = new Bike();
bicicleta.PagaImposto = false;

Console.WriteLine(c1.getEndereco().getEnderecoCompleto());

Console.WriteLine(aviao.ExibirDados());
Console.WriteLine(car.ExibirDados());

List<Veiculos> ListaVeiculos = new List<Veiculos>();
ListaVeiculos.Add(aviao);
ListaVeiculos.Add(car);
ListaVeiculos.Add(bicicleta);

List<Cliente> ListaClientes = new List<Cliente>();
ListaClientes.Add(c1);
ListaClientes.Add(c2);
ListaClientes.Add(c3);
ListaClientes.Add(c4);

foreach (var item in ListaClientes)
{
    Console.WriteLine(item.getNome());
}
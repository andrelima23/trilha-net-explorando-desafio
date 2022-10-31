using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa("Joãozinho", "Da Silva");
Pessoa p2 = new Pessoa("Maria", "Da Silva");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 360);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

//Reserva de 10 dias para teste de desconto
Reserva reserva2 = new Reserva(diasReservados: 10);
reserva2.CadastrarSuite(suite);
reserva2.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva2.ObterQuantidadeHospedes()}");
reserva2.ExibirHospedes();
Console.WriteLine($"Valor hospedagem: {reserva2.CalcularValorDiaria()}");
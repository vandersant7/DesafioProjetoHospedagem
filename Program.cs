using ProjetoHospedagem.Models;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Pessoa 1");
Pessoa p2 = new Pessoa(nome: "Pessoa 2");
Pessoa p3 = new Pessoa(nome: "Pessoa 3");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);

Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30M);

Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
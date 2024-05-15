using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();

Console.WriteLine("========================================");
Console.WriteLine("           --HOSPEDAGEM DIO--           ");
Console.WriteLine("========================================");

Pessoa p1 = new Pessoa(nome: "Abraão", sobrenome: "Azevedo Pereira");
Pessoa p2 = new Pessoa(nome: "Sophia", sobrenome: "Azevedo Pereira");

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 50M);

Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Quantidade de hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor total da estadia: {reserva.CalcularValorEstadia().ToString("C")}");
Console.WriteLine($"Valor da estadia por pessoa: {reserva.CalcularValorPessoa().ToString("C")}");
using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Console.WriteLine("========================================");
Console.WriteLine("           --HOSPEDAGEM DIO--           ");
Console.WriteLine("========================================");

Pessoa p1 = new Pessoa(nome: "Abraão", sobrenome: "Azevedo Pereira");
Pessoa p2 = new Pessoa(nome: "Sophia", sobrenome: "Azevedo Pereira");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 50M);

 // Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibi a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Quantidade de hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor total da estadia: {reserva.CalcularValorEstadia().ToString("C")}");
Console.WriteLine($"Valor da estadia por pessoa: {reserva.CalcularValorPessoa().ToString("C")}");
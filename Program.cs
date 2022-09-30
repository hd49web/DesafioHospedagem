using DesafioHospedagem.Modelo;

//modelo de hospede
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa( nome: "Hopesde Paulo");
Pessoa p2 = new Pessoa( nome: "Hopesde Tamiris");
Pessoa p3 = new Pessoa( nome: "Hopesde Gepvani");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);

//CRIAR SUITE
Suite suite =new Suite (tipoSuite: "Premium", capacidade: 3 , valorDiaria: 30);

// reserva com suite e hospede
Reserva reserva = new Reserva (diasReservados:15);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

//EXIBIR A QUANTIDADE DE HOSPEDES E O VALOR DE DIARIA

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária:{reserva.CalcularValorDiaria()}");
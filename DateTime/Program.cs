Console.WriteLine("Trabalhando com DateTime");

DateTime dataAtual = DateTime.Now;

Console.WriteLine(dataAtual);

//criar data especifica

DateTime dataHoje = new DateTime(2022, 05, 05);
Console.WriteLine(dataHoje);

DateTime dataHojeCompleta = new DateTime(2022, 05, 05, 14, 14, 00);
Console.WriteLine(dataHojeCompleta);

//extrair informações
Console.WriteLine();
Console.WriteLine("Extraindo informações");
Console.WriteLine(dataAtual);

Console.WriteLine(dataAtual.Year);
Console.WriteLine(dataAtual.Month);
Console.WriteLine(dataAtual.Day);
Console.WriteLine(dataAtual.Minute);
Console.WriteLine(dataAtual.Second);
Console.WriteLine(dataAtual.Millisecond);

//adicionando valores
Console.WriteLine();
Console.WriteLine("Adicionando valores");
Console.WriteLine(dataAtual.AddDays(30));
Console.WriteLine(dataAtual.AddMonths(3));
Console.WriteLine(dataAtual.AddHours(10));
Console.WriteLine(dataAtual.AddYears(100));

//Obtendo dia da semana e do ano
Console.WriteLine();
Console.WriteLine("Obtendo dia da semana e do ano");
Console.WriteLine(dataAtual.DayOfWeek);
Console.WriteLine(dataAtual.DayOfYear);

//Data no formato longo e curto
Console.WriteLine();
Console.WriteLine("Data no formato longo e curto");
Console.WriteLine(dataAtual.ToLongDateString());
Console.WriteLine(dataAtual.ToShortDateString());

//Hora no formato longo e curto
Console.WriteLine();
Console.WriteLine("Hora no formato longo e curto");
Console.WriteLine(dataAtual.ToLongTimeString());
Console.WriteLine(dataAtual.ToShortTimeString());

Console.ReadKey();  

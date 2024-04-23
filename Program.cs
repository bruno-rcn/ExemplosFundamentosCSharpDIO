using ExemplosFundamentos.Models;


// 1 - Utilizando a class pessoa

// Pessoa p1 = new Pessoa();
// p1.Nome = "Bruno";
// p1.Idade = 28;
// p1.Apresentar();



// ==================================================================================================================



// 2 - Tipos de dados
// https://www.tutorialspoint.com/csharp/csharp_data_types.htm
// https://learn.microsoft.com/pt-br/dotnet/api/system.datetime?view=net-6.0

string apresentacao = "Ola, seja bem vindo!";
int quantidade = 1;
double altura = 1.80; // nao ira considerar esse 0 do final
decimal preco = 1.80M; // decimal precisa do M no valor. Usado sempre para valores monetarios
DateTime data = DateTime.Now; // vai pegar a data atual da execucao do codigo
DateTime dataAddDays = DateTime.Now.AddDays(3); // adiciona 3 dias a partir da data de execucao
DateTime dataFormatadaDias = DateTime.Now;
DateTime dataFormatadaDiasHoras = DateTime.Now;

Console.WriteLine($"Valor da variavel string apresentacao: {apresentacao}"); // interpolacao de string com variavel
Console.WriteLine("Valor da variavel int quantidade: " + quantidade); // concatenacao de string mais variavel
Console.WriteLine($"Valor da variavel double altura: {altura}");
Console.WriteLine($"Valor da variavel decimal preco: {preco}");
Console.WriteLine($"Valor da variavel data: {data}");
Console.WriteLine($"Valor da variavel dataAddDays: {dataAddDays}");
Console.WriteLine($"Valor da variavel dataFormatadaDias: {dataFormatadaDias.ToString("dd/MM/yyyy")}");
Console.WriteLine($"Valor da variavel dataFormatadaDiasHoras: {dataFormatadaDiasHoras.ToString("dd/MM/yyyy HH:mm")}");

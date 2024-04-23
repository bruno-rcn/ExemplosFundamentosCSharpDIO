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

// string apresentacao = "Ola, seja bem vindo!";
// int quantidade = 1;
// double altura = 1.80; // nao ira considerar esse 0 do final
// decimal preco = 1.80M; // decimal precisa do M no valor. Usado sempre para valores monetarios
// DateTime data = DateTime.Now; // vai pegar a data atual da execucao do codigo
// DateTime dataAddDays = DateTime.Now.AddDays(3); // adiciona 3 dias a partir da data de execucao
// DateTime dataFormatadaDias = DateTime.Now;
// DateTime dataFormatadaDiasHoras = DateTime.Now;

// Console.WriteLine($"Valor da variavel string apresentacao: {apresentacao}"); // interpolacao de string com variavel
// Console.WriteLine("Valor da variavel int quantidade: " + quantidade); // concatenacao de string mais variavel
// Console.WriteLine($"Valor da variavel double altura: {altura}");
// Console.WriteLine($"Valor da variavel decimal preco: {preco}");
// Console.WriteLine($"Valor da variavel data: {data}");
// Console.WriteLine($"Valor da variavel dataAddDays: {dataAddDays}");
// Console.WriteLine($"Valor da variavel dataFormatadaDias: {dataFormatadaDias.ToString("dd/MM/yyyy")}");
// Console.WriteLine($"Valor da variavel dataFormatadaDiasHoras: {dataFormatadaDiasHoras.ToString("dd/MM/yyyy HH:mm")}");



// ==================================================================================================================



// 3 - Convertendo valores (Casting)
// A diferenca de Parse para convert esta no tratamento de valores nulos

int a = Convert.ToInt32("5"); // ToInt32 pq int tem 32 bits. Aqui o 5 ira virar inteiro
int b = int.Parse("5"); // tem a mesma funcionalidade que a linha acima
int aNulo = Convert.ToInt32(null); // vai dar 0
// int bNulo = int.Parse(null); // da erro pq o valor nao pode ser nulo
// int c = int.Parse("5c"); //  vai dar um erro pois a string contem letra e letra nao pode virar numero inteiro
int inteiro = 6;
string d = inteiro.ToString();

Console.WriteLine($"Valor da variavel a: {a}");
Console.WriteLine($"Valor da variavel b: {b}");
Console.WriteLine($"Valor da variavel aNulo: {aNulo}");
// Console.WriteLine($"Valor da variavel bNulo: {bNulo}");
// Console.WriteLine($"Valor da variavel c: {c}");
Console.WriteLine($"Valor da variavel d: {d}");


string txt = "15-";
int x = 0;

// VAi pegar o valor de entrada (txt) e tentar converter o valor e adicionar no valor de saida (out x). Caso nao de certo, vai imprimir o valor default da var de saida
int.TryParse(txt, out x);
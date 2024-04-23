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

// int a = Convert.ToInt32("5"); // ToInt32 pq int tem 32 bits. Aqui o 5 ira virar inteiro
// int b = int.Parse("5"); // tem a mesma funcionalidade que a linha acima
// int aNulo = Convert.ToInt32(null); // vai dar 0
// // int bNulo = int.Parse(null); // da erro pq o valor nao pode ser nulo
// // int c = int.Parse("5c"); //  vai dar um erro pois a string contem letra e letra nao pode virar numero inteiro
// int inteiro = 6;
// string d = inteiro.ToString();

// Console.WriteLine($"Valor da variavel a: {a}");
// Console.WriteLine($"Valor da variavel b: {b}");
// Console.WriteLine($"Valor da variavel aNulo: {aNulo}");
// // Console.WriteLine($"Valor da variavel bNulo: {bNulo}");
// // Console.WriteLine($"Valor da variavel c: {c}");
// Console.WriteLine($"Valor da variavel d: {d}");


// string txt = "15-";
// int x = 0;

// // VAi pegar o valor de entrada (txt) e tentar converter o valor e adicionar no valor de saida (out x). Caso nao de certo, vai imprimir o valor default da var de saida
// int.TryParse(txt, out x);



// ==================================================================================================================



// 4 - Operadores condicionais
// https://learn.microsoft.com/pt-pt/dotnet/csharp/language-reference/statements/selection-statements

// int quantidadeEstoque = 10;
// int quantidadeCompra = 4;

// // Se o valor for true executa o if se for false executa o else
// if(quantidadeEstoque >= quantidadeCompra)
// {
//     Console.WriteLine("Compra realizada!");
// }
// else
// {
//     Console.WriteLine("Nao tem a quantidade desejada em estoque!");
// }

// // if aninhado
// if(quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda invalida");
// }
// else if (quantidadeEstoque >= quantidadeCompra)
// {
//     Console.WriteLine("Compra realizada!");
// }
// else
// {
//     Console.WriteLine("Nao tem a quantidade desejada em estoque!");
// }

// Console.WriteLine("Digite uma letra:");
// string letra = Console.ReadLine(); // vai ler o que for digitado no console e armazenar na variavel

// // verificar se a letra e vogal ou nao
// switch (letra)
// {
//     case "a":
//         Console.WriteLine("vogal");
//         break;
//     case "e":
//         Console.WriteLine("vogal");
//         break;
//     case "i":
//         Console.WriteLine("vogal");
//         break;
//     case "o":
//         Console.WriteLine("vogal");
//         break;
//     case "u":
//         Console.WriteLine("vogal");
//         break;
//     default:
//         Console.WriteLine("Nao e uma vogal");
//         break;
// }

// // ou

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("vogal");
//         break;
//     default:
//         Console.WriteLine("Nao e uma vogal");
//         break;
// }



// ==================================================================================================================



// 5 - Operadores aritmeticos e class Math
// https://learn.microsoft.com/en-us/dotnet/api/system.math?view=net-8.0

Calculadora calc = new Calculadora();
calc.Somar(2, 5);
calc.Subtrair(10, 5);
calc.Dividir(4, 2);
calc.Multiplicar(3, 7);
calc.Potencia(3, 3);
calc.Seno(30);
calc.Cosseno(30);
calc.Tangente(30);
calc.RaizQuadrada(16);
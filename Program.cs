using DOTNETDeveloper.Models;

Console.WriteLine("Digite uma letra: ");
string letra = Console.ReadLine();

switch (letra) 
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
            Console.WriteLine("É uma vogal!");
            break;

            default:
            Console.WriteLine("Não é uma vogal!");
            break;

}


// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar venda? {possivelVenda}");

// if (quantidadeCompra == 0) 
// {
//     Console.WriteLine("venda inválida");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada com sucesso!");
// }
// else 
// {
//     Console.WriteLine("Desculpa, quantidade insuficiente no estoque!");
// }


//TryParse para não haver quebra de código
// string a = "15-";

// //int b = 0;

// int.TryParse(a, out  int b);

// Console.WriteLine(b);
// Console.WriteLine("Conversão com sucesso!");


// ordem dos operadores
// double a = 4 / (2 + 2 );

// Console.WriteLine(a);


//Cast implícito: conversão de diferentes tipos auto
//Convert para int ToInt
// long a = long.MaxValue;
// int b = Convert.ToInt32(a);

// int a = int.MaxValue;
// long b = a;

// Console.WriteLine(b);


// ToString, converte em string.
// int inteiro = 11;
// string a = inteiro.ToString();

// Console.WriteLine(a);


//cast - casting (convert)
// diferença entre parse e convert : tratamento de valores nullos.
// int a = Convert.ToInt32("0");
// int b = int.Parse("9");

// Console.WriteLine(a);
// Console.WriteLine(b);


// int a = 10;
// int b = 20;
// int c = a + b;

// //c += 5;
// c -= 5;

// Console.WriteLine(c);


// DateTime dataAtual = DateTime.Now;
// Console.WriteLine(dataAtual.ToString("dd/MM/yy HH:mm "));

// string apresentacao = "Olá, seja bem vindo";
// int quantidade = 1;
// double altura = 1.57;
// decimal preco = 1.89M;
// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variavel quantidade: " + quantidade);
// Console.WriteLine("Valor da variavel altura: " +altura);
// Console.WriteLine("Valor da variavel preco: " + preco);
// Console.WriteLine("Valor da variavel condicao: " + condicao);


// Pessoa p = new Pessoa();

// p.Nome = "Bryan";
// p.Idade = 25;
// p.Apresentar();

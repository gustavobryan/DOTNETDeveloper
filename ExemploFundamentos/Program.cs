using ExemploFundamentos.Common.Models;

int[] arrayInteiros = new int[4];

arrayInteiros[0] = 11;
arrayInteiros[1] = 12;
arrayInteiros[2] = 13;
arrayInteiros[3] = 14;

Console.WriteLine("percorrendo Array com FOR");
for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição N° {contador} - {arrayInteiros[contador]}");
}

Console.WriteLine("percorrendo array com FOREACH");

int contadorForeach = 0;
foreach (int valor in arrayInteiros)
{
    Console.WriteLine($"Posição N° {contadorForeach} - {valor}");
    contadorForeach++;
}



// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Bryan";
// pessoa1.Idade = 25;
// pessoa1.Apresentar();



// string opcao;
// bool exibirMenu = true;

// while (exibirMenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção: ");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch (opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;

//         case "2":
//             Console.WriteLine("Busca de cliente");
//             break;

//         case "3":
//             Console.WriteLine("Apagar cliente");
//             break;

//         case "4":
//             Console.WriteLine("O programa se encerrou");
//             exibirMenu = false;
//             break;

//         default:
//             Console.WriteLine("Opção inválida");
//             break;
//     }

// }


// int soma = 0, numero = 0;

// do 
// {
//     Console.WriteLine("Digite um número (0 para parar): ");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// } while(numero != 0);

// Console.WriteLine($"Tota da soma dos números digitados é: {soma}");


// int numero = 5;
// int contador = 0;

// while (contador <= 10)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//     contador++;
// }


// int numero = 5;

// for(int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }


// Calculadora calc = new Calculadora();

// calc.RaizQuadrada(9);

// calc.Somar(10, 30);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 5);
// calc.Dividir(2, 2);
// calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);

// int numero = 10;

// Console.WriteLine(numero);

// Console.WriteLine("Incrementando o 10");
// numero ++;

// int numero2 = 20;

// Console.WriteLine("Decrementando o 20");
// numero2--;

// Console.WriteLine(numero);
// Console.WriteLine(numero2);


// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine();

// switch (letra) 
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//             Console.WriteLine("É uma vogal!");
//             break;

//             default:
//             Console.WriteLine("Não é uma vogal!");
//             break;

// }


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

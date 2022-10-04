// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Diva!");
//Em program.css fica o código fonte da aplicação
//dotnet run => para compilar e executar
Console.WriteLine("WriteLine é um método");
Console.WriteLine("Para criar uma variável precisamos especificar o tipo dela");
Console.WriteLine("Podemos usar a vírgula e criar mais de uma variável do mesmo tipo");
Console.WriteLine("Para finalizar uma declaração precisamos usar OBRIGATORIAMENTE o ; ");
//tipos:
int value1 = 10;
value1++;
Console.WriteLine("O valor do número é : " + value1 );
Console.WriteLine("Não podemos usar áspas simples");
Console.WriteLine("Para concatenar usamos o +");


 bool teste = true;
 Console.WriteLine(teste);


 char c; //variável é declarada, mas seu valor nunca é lido 
 Console.WriteLine("No caso abaixo a variável C foi declarada e seu tipo também, mas nenhum valor foi atribuido");


 int value3;  //é uma instrução
int value2 = value3 = 10; //as 2 variáveis recebem o valor 10 | expressão
Console.WriteLine(value2);
Console.WriteLine(value3);
value3--; //aqui o value3 valia 10 e foi decrementado 1
Console.WriteLine(value3);

//TERNÁRIO

var value4 = value3 == 42 ? true : false;
Console.WriteLine(value4);
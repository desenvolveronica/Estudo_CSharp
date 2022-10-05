//programa pra calcular a idade de uma pessoa

















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

var value4 = value3 == 42 ? 10 : 20;
Console.WriteLine(value4);

Console.WriteLine("O CSharp é uma linguagem de tipagem estática");
Console.WriteLine("O compilador verifica se estamos usqando os tipos de forma correta");
Console.WriteLine(" ");
Console.WriteLine("A partir do momento que é feito a definição do tipo da variável, esse tipo é estático e não pode ser alterado");
Console.WriteLine("JavaScript é uma linguagem de tipagem dinâmica");
Console.WriteLine("TypeScript é de tipagem estática durante o tempo de compilação");
Console.WriteLine(" ");
Console.WriteLine("O namespace é o System onde o console é uma classe");
Console.WriteLine("A classe console é estática ou seja, não podemos criar um objeto do tipo console");
Console.WriteLine("A classe console não pode ser herdada");
Console.WriteLine(" ");
Console.WriteLine("Um namespace é uma forma lógica de organizar tipos");
Console.WriteLine("Édeclarado o namespace e dentro dele é declarado os membros");
Console.WriteLine(" ");

Console.WriteLine("Uma string também possue membros de instância que acessamos com o ponto(.)");

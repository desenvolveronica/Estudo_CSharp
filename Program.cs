//programa pra calcular a idade de uma pessoa
Console.WriteLine("Hello, Diva!");
Console.Write("Digite seu nome: ");
string name = Console.ReadLine();
// Console.WriteLine("Olá, " + name + " como você está? ");
// Console.WriteLine("As strings no CSharp sempre vai usar aspas duplas");
Console.WriteLine(" ");
// Console.WriteLine("Fazendo interpolação antes das áspas duplas coloca o $ e a variável dentro de {}");
Console.Write($"Olá, como você está, {name} ?");
string estado = Console.ReadLine();

if(estado == "bem"){
          Console.WriteLine("Fico feliz que esteja bem");
}else Console.WriteLine("Estude mais um pouco e tudo melhora");


Console.Write("Digite o ano do seu nascimento: ");
int ano = int.Parse(Console.ReadLine());
Console.WriteLine($"Olá {name} nascida em {ano}");
// OBSERVAÇÃO: ReadLine retorna uma STRING
//utilizando o método para converter string em numero INT.PARSE()
//onde colocamos a chamada do ReadLine() dentro para converter
int result = 2022 - ano;

if(result >= 18  && name == "diva"){
          Console.WriteLine($"Calculando descobri que você, Divona, tem {result} anos");}
          else if (result >= 18){
                    Console.WriteLine($"Calculando descobri que você, {name}, tem {result} anos");
          } else {
                    Console.WriteLine($"Ixi você é menor de idade pois tem {result} anos");
          }

Console.Write("Você está estudando qual linguagem de programação? ");
string linguagem = Console.ReadLine(); //readline é onde o user vai escrever
//fazendo if com a variável linguagem
if(linguagem == "css" ){
          Console.WriteLine("Atenção!! css não é linguagem de programação");
}else{
          Console.WriteLine($"Entendi! você {name} possui {result} anos e está estudando {linguagem}...");
}

Console.Write("Digite um número de 1 a 5: ");
int numero = Console.Read();

if(numero == 1 || name == "diva"){
          // || é equivalente ao OU
          Console.WriteLine("Eu sei que vc escolheu 1 ou se chama diva");
}else if(numero == 2 || name == "diva"){
          Console.WriteLine("Eu sei que você escolheu 2 ou se chama diva");
}else if(numero == 3){
          Console.WriteLine("Eu se que você escolheu 3");
}else{
          Console.WriteLine($"Sua situação {name} é profunda");
}
















// See https://aka.ms/new-console-template for more information
//Em program.css fica o código fonte da aplicação
//dotn run => para compilar e executar
// Console.WriteLine("WriteLine é um método");
// Console.WriteLine("Para criar uma variável precisamos especificar o tipo dela");
// Console.WriteLine("Podemos usar a vírgula e criar mais de uma variável do mesmo tipo");
// Console.WriteLine("Para finalizar uma declaração precisamos usar OBRIGATORIAMENTE o ; ");
//tipos:
// int value1 = 10;
// value1++;
// Console.WriteLine("O valor do número é : " + value1 );
// Console.WriteLine("Não podemos usar áspas simples");
// Console.WriteLine("Para concatenar usamos o +");


//  bool teste = true;
//  Console.WriteLine(teste);


//  char c; //variável é declarada, mas seu valor nunca é lido 
//  Console.WriteLine("No caso abaixo a variável C foi declarada e seu tipo também, mas nenhum valor foi atribuido");


//  int value3;  //é uma instrução
// int value2 = value3 = 10; //as 2 variáveis recebem o valor 10 | expressão
// Console.WriteLine(value2);
// Console.WriteLine(value3);
// value3--; //aqui o value3 valia 10 e foi decrementado 1
// Console.WriteLine(value3);

//TERNÁRIO

// var value4 = value3 == 42 ? 10 : 20;
// Console.WriteLine(value4);

// Console.WriteLine("O CSharp é uma linguagem de tipagem estática");
// Console.WriteLine("O compilador verifica se estamos usqando os tipos de forma correta");
// Console.WriteLine(" ");
// Console.WriteLine("A partir do momento que é feito a definição do tipo da variável, esse tipo é estático e não pode ser alterado");
// Console.WriteLine("JavaScript é uma linguagem de tipagem dinâmica");
// Console.WriteLine("TypeScript é de tipagem estática durante o tempo de compilação");
// Console.WriteLine(" ");
// Console.WriteLine("O namespace é o System onde o console é uma classe");
// Console.WriteLine("A classe console é estática ou seja, não podemos criar um objeto do tipo console");
// Console.WriteLine("A classe console não pode ser herdada");
// Console.WriteLine(" ");
// Console.WriteLine("Um namespace é uma forma lógica de organizar tipos");
// Console.WriteLine("Édeclarado o namespace e dentro dele é declarado os membros");
// Console.WriteLine(" ");

// Console.WriteLine("Uma string também possue membros de instância que acessamos com o ponto(.)");

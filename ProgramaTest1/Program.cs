//Nesse programa foi feito o calculo da area de um retangulo.

//class Variaveis
//{
//    static void Main()
//    {


//int x = 4;
// double y = 3.3;
//const double frequence = 60;

//double area = x * y;

//Console.WriteLine("A área do quadrado é " + area);


// conversão implícita 

//    int x = 4;
// double x = y; 

//Console.WriteLine(y);

// CONVERSÃO EXPLÍCITA 

//double nota = 8.6;
//int notaconvertida = (int)nota;
//Console.WriteLine(notaconvertida);


//Convert

//    Console.WriteLine("digite qual numero é sua casa: ");
//    String numeroCasa = Console.ReadLine();
//    int numero = int.Parse(numeroCasa);
//    Console.WriteLine("Número é sua casa: {0}", numero);

//    numero = Convert.ToInt32(numeroCasa);
//    Console.WriteLine(numero);
//    }

//} 

// Nesse projeto foi ensinado a fazer formatações ! 

//class Formatação
//{
//    static void Main()
//    {
//        double x = 20.232;
//        Console.WriteLine(x.ToString("F1"));
//        Console.WriteLine(x.ToString("C")); 
//        Console.WriteLine(x.ToString("P"));

//    }
//}

//Nesse cosigo foi  feito uma leitura de dados 

class LeituraDeDados
{
    static void Main()
    {
        Console.WriteLine("Qual seu nome ?");
        string? nome = Console.ReadLine();
        Console.WriteLine("Quantos anos voce tem?");
        int idade = int.Parse(Console.ReadLine());
        Console.WriteLine("Quantos irmãos voce tem?");
        int irmao = int.Parse(Console.ReadLine());

        Console.WriteLine("seu nome é {0} é a sua idade é {1}, e voce tem {2} Irmão. ", nome, idade, irmao);
    }
}

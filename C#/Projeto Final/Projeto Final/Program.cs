//float media = 0;
//string valor;
//Console.WriteLine("Olá, bem vindo ao programa de calculo de média!");
//Console.WriteLine("Irei auxiliar voce a calcular a média do seu aluno!");

//int nota1;
//nota1 = Convert.ToInt16(media);
//Console.WriteLine("Digite a primeira nota: ");
//Console.ReadLine();

//int nota2;
//nota2 = Convert.ToInt16(media);
//Console.WriteLine("digite a segunda nota: ");
//Console.ReadLine();

//int nota3;
//nota3 = Convert.ToInt16(media);
//Console.WriteLine(" Digite a terceira nota: ");
//Console.ReadLine();

//media = Convert.ToInt32(nota1 + nota2 + nota3) / 3;
//Console.WriteLine("A média do aluno é {0}", media);

//if (media < 7)
//{
//    Console.WriteLine("Aluno esta em recuperação");

//}
//else
//{
//    Console.WriteLine("Aluno Aprovado");
//}


using System.Globalization;

float media = 0;
string entradaUsuario;
Console.WriteLine("Olá, bem vindo ao programa de calculo de média!");
Console.WriteLine("Irei auxiliar voce a calcular a média do seu aluno!");

int nota1;
Console.WriteLine("Digite a primeira nota: ");
entradaUsuario = Console.ReadLine();
nota1 = Convert.ToInt32(entradaUsuario);

int nota2;
Console.WriteLine("digite a segunda nota: ");
entradaUsuario = Console.ReadLine();
nota2 = Convert.ToInt32(entradaUsuario);

int nota3;
Console.WriteLine(" Digite a terceira nota: ");
nota3 = Convert.ToInt32(Console.ReadLine());

media = Convert.ToInt32(nota1 + nota2 + nota3) / 3;
Console.WriteLine("A média do aluno é {0}", media);

if (media < 0.7)
{
    Console.WriteLine("Aluno esta em recuperação");

}
else
{
    Console.WriteLine("Aluno Aprovado");
}

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


    //NESSE CODIGO FOI REALIZADO A VARIAVEL STRING.

//float media = 0;
//string entradaUsuario;
//Console.WriteLine("Olá, bem vindo ao programa de calculo de média!");
//Console.WriteLine("Irei auxiliar voce a calcular a média do seu aluno!");

//int nota1;
//Console.WriteLine("Digite a primeira nota: ");
//entradaUsuario = Console.ReadLine();
//nota1 = Convert.ToInt32(entradaUsuario);

//int nota2;
//Console.WriteLine("digite a segunda nota: ");
//entradaUsuario = Console.ReadLine();
//nota2 = Convert.ToInt32(entradaUsuario);

//int nota3;
//Console.WriteLine(" Digite a terceira nota: ");
//nota3 = Convert.ToInt32(Console.ReadLine());

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

 
bool opcao = true;
string entradaUsuario;
Console.WriteLine("Olá, irei realizar a soma de numeros que voce deseja ate desejar parar");

Console.WriteLine("Digite o valor inicial");
float inicial;
entradaUsuario = Console.ReadLine();
inicial = Convert.ToInt32(entradaUsuario); 

while(opcao == true)
{
    Console.WriteLine("Digite o noumero que deseja somar ao numero inicial:");
    float n1;
    string entradaUsuario2;
    entradaUsuario2 = Console.ReadLine();
    n1 = Convert.ToInt16(entradaUsuario2);

    inicial = inicial + n1;
    Console.WriteLine("A soma ate o momento é {0}", inicial);

    Console.WriteLine("Deseja sair do programa ? 1 - sim 2 - não");
    int saida; 
    string entradaUsuario3;
    entradaUsuario3 = Console.ReadLine();
    saida = Convert.ToInt32(entradaUsuario3);

    switch (saida)
    {
        case 1:
            Console.WriteLine("Saindo do programa !");
            opcao = false;
                break;
        case 2:
            Console.WriteLine("Tudo bem, vamos continuar a soma:");
            break;
        default:
            Console.WriteLine("Opção invalida. Retornando para a soma.");
            break; 

    }

}

//double nota1 = 8.0;
//double nota2 = 9.0;

//Console.WriteLine("Nota maior que 7? {0}", nota2 > 7.0);
//Console.WriteLine("Tirou 10? {0}", nota2 == 10.0); 

//Console.WriteLine("Digite sua nota: ");
//double.TryParse(Console.ReadLine(), out double nota);
//Console.WriteLine("Nota maior que 7? {0}", nota > 7.0);
//Console.WriteLine("Tirou 10? {0}", nota == 10.0);


//var atividade1 = true;
//var atividade2 = false;
//var todas = atividade1 && atividade2;
//Console.WriteLine("fez todas as atividaes? {0}", todas);
//var umaApenas = atividade1||atividade2;
//Console.WriteLine("Fez pelo menos uma das atividades? {0}", umaApenas);
//Console.WriteLine(" Não fez nenhuma? {0}", !umaApenas);


// Operadores Unários 

//var X = false;
//var n1 = 6;
//var n2 = 5;
//var n3 = 7;
//var n4 = 8;

//Console.WriteLine(!X);
//n3++;
//Console.WriteLine(n3);
//n4--;
//Console.WriteLine(n4);

//Console.WriteLine(n1--);
//Console.WriteLine(n1);
//Console.WriteLine(n2-- == ++n1);


//ESTRUTURAS DE CONTROLE IF/ELSE
//As ações que serão executadas devem estar entre as chaves que são abertas após a imposição das condições. 

//var n1 = 5;
//var n2 = 9;
//var n3 = 10;
//if (n1 < n2){
//    Console.WriteLine(n1 + n2);
//}
//if (n3 < n2)
//{
//    Console.WriteLine(n3+n2);
//}
// nesse caso foi verificado que se o valor for menor que o outro, aparece na tela caso contrario não. 

//ELSE 


//var n1 = 5;
//var n2 = 9;
//var n3 = 10;
//if (n1 < n2)
//{
//    Console.WriteLine("condição 1 é satisfeita !!");
//    Console.WriteLine("resultado da soma é {0}", n1 + n2);
//}
//else if (n3 < n2)
//{
//    Console.WriteLine(n3 + n2);

//    Console.WriteLine("condição 2 não é satisfeita !!");
//}

// ESTRUTURA SWITCH 
//O SWITCH FUNCIONA PARECIDO COM O IF MAS A PARTIR DE ESCOLHAS. 

//Console.WriteLine("Qual a nota que voce dar para o prato? 0, 5 ou 10");
//int.TryParse(Console.ReadLine(), out int nota);
//switch (nota)
//{
//    case 0:
//        Console.WriteLine("comida muito ruim");
//        break;
//    case 5:
//        Console.WriteLine("comida razoavel");
//        break;
//    case 10:
//        Console.WriteLine("comida muito boa");
//        break;
//    default:
//        Console.WriteLine("Nota inexistente");
//        break;
//}

//ESTRUTURA DE CONTROLE - WHILE
int n1 = 1; 

while (n1 <= 15)
{
    Console.WriteLine(n1);
    n1 = n1 + 1;
}

// projeto criado por mim para acessar um certo sistema ultilizando a senha correta. 

//int senha;
//string textoDoUsuario;
//Console.WriteLine("Qual a senha ? ");
//textoDoUsuario = Console.ReadLine();
//senha = Convert.ToInt32(textoDoUsuario);
//switch(senha) 
//{
//    case 1011:
//        Console.WriteLine("SENHA CORRETA\nCONECTADO - BEM VINDO");
//        break;
//    case 1234:
//        Console.WriteLine("SENHA INCORRETA");
//        break;
//    default:
//        Console.WriteLine("NAO CORRESPONDE");
//        break;

// }
// estrutura For 

//for (int n1 = 1; n1 <= 10; n1++)
//{
//    Console.WriteLine(n1);
//}
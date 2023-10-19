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

// estruturas de controle - IF/ELSE 

var n1 = 5;
var n2 = 9;
var n3 = 10;
if (n1 < n2){
    Console.WriteLine(n1 + n2);
}
if (n3 < n2)
{
    Console.WriteLine(n3+n2); // nesse caso foi verificado que se o valor for menor que o outro, aparece na tela caso contrario não. 
}

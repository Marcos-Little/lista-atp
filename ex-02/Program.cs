//Faça um programa que receba o preço de um produto, calcule e mostre o novo preço, sabendo-
//se que este sofreu um desconto de 10%.
double preco, desconto;
Console.Write("Informe o preço do produto: ");
preco = double.Parse(Console.ReadLine());
desconto = preco * 0.1;
preco = preco - desconto;
Console.WriteLine("O novo preço do produto é {0:C}", preco);
Console.ReadKey();
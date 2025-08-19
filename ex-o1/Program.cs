//Faça um programa que receba duas notas, calcule e mostre a média ponderada dessas notas,
//considerando peso 2 para a primeira nota e peso 3 para a segunda nota
double nota1, nota2,media;
Console.Write("Informe a Primeira nota: ");
nota1 = double.Parse(Console.ReadLine());
Console.Write("Informe a Segunda nota: ");
nota2 = double.Parse(Console.ReadLine());
media = (double)((nota1 * 2) + (nota2 * 3) / (2 + 3));
Console.WriteLine("A média ponderada das notas é " + media);
Console.ReadKey();
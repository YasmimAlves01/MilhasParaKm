int milha;
double KM;

Console.WriteLine("BEm-vindo ao contador conversor de milhas em KM");
Console.WriteLine("Por favor digite a medida em milhas a ser convertido para KM");
milha = Convert.ToInt32(Console.ReadLine());

KM = milha * 1.609 ; 

Console.WriteLine($"as milhas digitadas foram: {milha}, a conversão para KM: {KM} ");

using System;
int op = 0;
Double c, k, f = 0;


Console.WriteLine("Informe o valor em celsius");
c = double.Parse(Console.ReadLine());
Console.WriteLine("Informe para qual medida você quer converter:");
Console.WriteLine("1-Kelvin\n2-Fahrenheit");
op = int.Parse(Console.ReadLine());

if (op == 1)
{
    k = c + 273.15;
    Console.WriteLine("O valor convertido é de: " + k + "");
    Console.ReadKey();
}
else if (op == 2)
{
    f = 1.8 * f + 32;
    Console.WriteLine("O valor convertido é de: " + f + "");
    Console.ReadKey();
}
else 
{
    Console.WriteLine("Você informou uma opção não válida.");
    Console.ReadKey();
}
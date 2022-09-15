using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string nome_aluno = "";
        double nota1, nota2, nota3, nota4, nota5, media=0;

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(value: "Bem-vindo, Insira o nome do aluno");
        Console.ResetColor();
        nome_aluno = Console.ReadLine();
        Console.WriteLine("Insira a pontuação da nota 1:");
        nota1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Insira a pontuação da nota 2:");
        nota2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Insira a pontuação da nota 3:");
        nota3 = double.Parse(Console.ReadLine());
        Console.WriteLine("Insira a pontuação da nota 4:");
        nota4 = double.Parse(Console.ReadLine());
        Console.WriteLine("Insira a pontuação da nota 5:");
        nota5 = double.Parse(Console.ReadLine());
        media = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("O aluno: " + nome_aluno + " Tem a média de: " + media + "");
        Console.ReadKey();
    }
}
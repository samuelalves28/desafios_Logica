﻿using desafios_Logica._01;
using desafios_Logica._02;
using desafios_Logica._03;

class Program
{
    private static void Main()
    {
        Console.WriteLine("Escolha a operação: ");
        Console.WriteLine("--------------------");
        Console.WriteLine("1 - Calculo triangulo X e Y.");
        Console.WriteLine("2 - Calculo diametro do circulo");
        Console.WriteLine("3 - Calcule a diferença");
        Console.WriteLine("--------------------");

        Console.WriteLine("");
        Console.Write("Escolha: ");


        var opcao = Console.ReadKey();

        Console.WriteLine("");
        Console.WriteLine("--------------------");
        Console.WriteLine("");

        switch (opcao.KeyChar)
        {
            case '1':
                Execute01.Execute();
                break;
            case '2':
                Execute02.Executar();
                break;      
            case '3':
                Execute03.Executar();
                break;

        }
    }
}
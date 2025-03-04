namespace desafios_Logica._03;

public class Execute03
{
    public static void Executar()
    {
        var letras = new List<string> { "A", "B", "C", "D" };
        var dicionario = new Dictionary<string, int>();

        Console.WriteLine("Infome os valores: ");
     
        for (int i = 0; i < letras.Count(); i++)
        {
            Console.Write($"{letras[i]}:");
            var valor = Console.ReadLine();
            dicionario.Add(letras[i], Convert.ToInt32(valor));
        }

        var diferenca = (dicionario["A"] * dicionario["B"] - dicionario["C"] * dicionario["D"]);

        Console.WriteLine($"DIFERENCA = {diferenca}");
    }
}

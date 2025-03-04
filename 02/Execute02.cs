namespace desafios_Logica._02;

public class Execute02
{
    public static void Executar()
    {
        Console.WriteLine("Informe o raio do circulo: ");
        var diametro = Convert.ToDouble(Console.ReadLine().Replace(".", ","));

        var area = Math.PI * Math.Pow((diametro / 2), 2);

        Console.WriteLine($"A área do circulo é: {area.ToString("F4")}");
    }
}

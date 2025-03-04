namespace desafios_Logica._01;

public class Execute01
{
    public static void Execute()
    {
        var valoresTrianguloX = new List<double>();
        var valoresTrianguloY = new List<double>();

        ValoresTriangulo(valoresTrianguloX, "X");
        ValoresTriangulo(valoresTrianguloY, "Y");

        var calculoAreaX = CalculoArea(valoresTrianguloX);
        var calculoAreaY = CalculoArea(valoresTrianguloY);

        Console.WriteLine($"Area do triangulo X: {calculoAreaX}");
        Console.WriteLine($"Area do triangulo Y: {calculoAreaY}");

        if (calculoAreaX > calculoAreaY) Console.WriteLine($"O triangulo X é maior que o triangulo Y");
        else Console.WriteLine($"O triangulo Y é maior que o triangulo X");
    }

    #region Metodos Privados

    private static void ValoresTriangulo(List<double> valores, string triangulo)
    {
        Console.WriteLine($"Digite os valores do triangulo {triangulo}:");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("");
            var valor = Console.ReadLine();
            valores.Add(Convert.ToDouble(valor.Replace(".", ",")));
        }
    }

    private static double CalculoP(List<double> valores)
    {
        var A = valores[0];
        var B = valores[1];
        var C = valores[2];

        var p = (A + B + C) / 2;

        return p;
    }

    private static double CalculoArea(List<double> valores)
    {
        var A = valores[0];
        var B = valores[1];
        var C = valores[2];

        var p = CalculoP(valores);

        var calc = p * (p - A) * (p - B) * (p - C);
        var area = Math.Sqrt(Convert.ToDouble(calc));

        return area;
    }

    #endregion
}

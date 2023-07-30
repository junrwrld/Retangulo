using System;
using System.Formats.Asn1;
using System.Globalization;


namespace retangulo1
{
    public class _retangulo1
    {
        static void Main(string[] args)
        {
            Retangulo valores = new Retangulo();

            Console.WriteLine("Entre com a largura e altura: ");
            valores.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valores.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = " + valores.CalculoArea().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = " + valores.CalculoPerimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + valores.CalculoDiagonal().ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
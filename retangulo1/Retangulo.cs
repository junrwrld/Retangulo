using System;
using System.Globalization;


namespace retangulo1
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double CalculoArea()
        {
            return Largura * Altura;
        }

        public double CalculoPerimetro()
        {
            return 2 * (Largura + Altura);
        }

        public double CalculoDiagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }



    }




}

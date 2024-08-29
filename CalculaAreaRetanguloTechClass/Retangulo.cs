using System;

namespace CalculaAreaRetanguloTechClass
{
    public class Retangulo
    {
        public double Altura;
        public double Largura;



        public double CalculaPerimetro()
        {
             return 2 * (Altura + Largura)  ;
        }

        public double CalculaArea()
        {
            return Altura * Largura;
        }

        public double CalculaDiagonal()
        {
             return Math.Sqrt(Math.Pow(Altura,2) + (Math.Pow(Largura,2)));
        }
    }



}

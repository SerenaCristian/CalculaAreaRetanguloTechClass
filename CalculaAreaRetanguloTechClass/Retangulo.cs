using System;

namespace CalculaAreaRetanguloTechClass
{
    public class Retangulo
    {
        public double Altura;
        public double Largura;


        public  Retangulo(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;
        }


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

        public override string ToString() 
        {
            return $"O Valor da Área é: {CalculaArea():F2}\n" +
            $"O Valor do Perimetro é: {CalculaPerimetro():F2}\n" +
            $"O Valor da Diagonal é: {CalculaDiagonal():F2}";
        }
    }



}

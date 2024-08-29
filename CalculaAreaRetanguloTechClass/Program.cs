using System;

namespace CalculaAreaRetanguloTechClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            string sep = new string('.', 45);
            Console.WriteLine("Programa para Calcular a Área de um Retangulo");
            Console.WriteLine(sep);

            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Por Favor Digite a Altura do Retangulo: ");
            retangulo.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Por Favor Digite a Largura do Retangulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine());

            Console.WriteLine(sep);

            Console.WriteLine($"O Valor da Área é: {retangulo.CalculaArea():F2}");
            Console.WriteLine(sep);
            Console.WriteLine($"O Valor do Perimetro é: {retangulo.CalculaPerimetro():F2}");
            Console.WriteLine(sep);
            Console.WriteLine($"O Valor da Diagonal é: {retangulo.CalculaDiagonal():F2}");

        }
    }
}

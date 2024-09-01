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

         
            Console.WriteLine("Por Favor Digite a Altura do Retangulo: ");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Por Favor Digite a Largura do Retangulo: ");
            double largura = double.Parse(Console.ReadLine());


            Retangulo retangulo = new Retangulo(altura, largura);
            
            Console.WriteLine(sep);

            Console.WriteLine(retangulo);
         

        }
    }
}

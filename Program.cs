using System;

namespace Projetil
{
    class Program
    {
        static void Main(string[] args)
        {
           const double g = 9.80665;

           double anguloGraus;
           double velocidade;
           double anguloRadianos;
           double alcance;
           double altura;

           Console.WriteLine("==============");
           Console.WriteLine("|| Projétil ||");
           Console.WriteLine("==============");

           Console.Write("Entre com a velocidade, em m/s..: ");
           velocidade = Convert.ToDouble(Console.ReadLine());

           Console.Write("Entre com o ângulo, em graus....: ");
           anguloGraus = Convert.ToDouble(Console.ReadLine());

           anguloRadianos = anguloGraus * (Math.PI/180);

           Console.WriteLine();
           
           alcance = (Math.Pow(velocidade, 2) *  Math.Sin(2 * anguloRadianos)) / g;
           Console.WriteLine ($"Alcance......: {alcance:N2}");

           altura = Math.Pow((velocidade * Math.Sin(anguloRadianos)), 2) / (2 * g);
           Console.WriteLine ($"Altura máxima..:{altura:N2}");
        }
    }
}

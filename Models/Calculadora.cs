using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosFundamentos.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} x {y} = {x * y}");
        }

        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Potencia(int x, int y)
        {
            double pow = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {pow}");
        }

        public void Seno(double angulo)
        {
            double rad = angulo * Math.PI / 180;
            double sen = Math.Sin(rad);
            Console.WriteLine($"seno de {angulo} = {Math.Round(sen, 4)}");
        }

        public void Cosseno(double angulo)
        {
            double rad = angulo * Math.PI / 180;
            double cos = Math.Cos(rad);
            Console.WriteLine($"cosseno de {angulo} = {Math.Round(cos, 4)}");
        }

        public void Tangente(double angulo)
        {
            double rad = angulo * Math.PI / 180;
            double tang = Math.Tan(rad);
            Console.WriteLine($"tangente de {angulo} = {Math.Round(tang, 4)}");
        }

        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"raiz quadrada de {x} = {raiz}");
        }
    }
}
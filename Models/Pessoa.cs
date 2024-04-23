using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosFundamentos.Models
{
    /// <summary>
    /// Representa uma pessoa Fisica
    /// </summary>
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        
        public void Apresentar()
        {
            Console.WriteLine($"Ola, meu nome e {Nome} e eu tenho {Idade} anos.");
        }
        
    }
}
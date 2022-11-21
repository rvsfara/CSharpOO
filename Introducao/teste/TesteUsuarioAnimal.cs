using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Introducao.model;

namespace Introducao.teste
{
    internal class TesteUsuarioAnimal
    {
        public static void Main(string[] args)
        {
            Usuario Usuario = new Usuario();
            Animal Animal = new Animal();
            Usuario.Name = "Rafael Vieira dos Santos";
            Usuario.Email = "rvsfara@gmail.com";
            Usuario.Idade = 31;

            Animal.Nome = "Choco";
            Animal.Especie = "Cachorro";
            Animal.Idade = 5;

            Usuario.Animal = Animal;

            Console.WriteLine("Iniciando o Programa");
            Console.WriteLine("Nome: " + Usuario.Name);
            Console.WriteLine("Email: " + Usuario.Email);
            Console.WriteLine("Idade: " + Usuario.Idade);

            Console.WriteLine("Pet é um: " + Usuario.Animal.Especie);
            Console.WriteLine("Nome do pet: " + Usuario.Animal.Nome);
            Console.WriteLine("Idade do pet: " + Usuario.Animal.Idade);
            Console.WriteLine("Fim do Programa");
        }
    }
}

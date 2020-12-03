using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_individual_Tema_Vetores_Hotel
{
    class Hospedes
    {
        public string Nome { get; set; } //Get e set dos nomes dos hóspedes
        public string Email { get; set; } //Get e set dos emails dos hóspedes
        public Hospedes(string nome, string email) //Construtor personalizado
        {
            Nome = nome;
            Email = email;
        }
        public override string ToString() //Metodo que retorna nome e email ao program
        {
            return Nome + ", " + Email;
        }
    }
}
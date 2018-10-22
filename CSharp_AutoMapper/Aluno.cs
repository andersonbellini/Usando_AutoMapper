using System;

namespace CSharp_AutoMapper
{
    public class Aluno
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public Endereco Endereco { get; set; }
        public string Genero { get; set; }
        public int Idade { get; set; }
        public DateTime Nascimento { get; set; }
    }

    public class Endereco
    {
        public string Pais { get; set; }
        public string Cidade { get; set; }
        public string Rua { get; set; }
        public string Cep { get; set; }
    }

    public class AlunoViewItem
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Genero { get; set; }
        public int Idade { get; set; }
        public string Nascimento { get; set; }
    }

  
}

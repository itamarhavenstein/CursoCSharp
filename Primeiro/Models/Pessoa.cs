using System;

namespace Primeiro.Models
{
  class Pessoa
  {
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Email { get; set; }
    
    public Pessoa() {}
    
    public Pessoa(string nome, string email)
    {
        this.Nome = nome;
        this.Email = email;
    }
  }
}
using System;

namespace jogo_da_velha.model
{
    public class Usuario
    {
        public int UserID { get; set; }
        public string Nome { get; set; }
        public string Nick { get; set; }
        public string Password { get; set; }
        public int Pontos { get; set; }
        public DateTime CreatedDate { get; set; }

        public Usuario(int userID, string nome, string nick, string password, int pontos, DateTime createdDate)
        {
            UserID = userID;
            Nome = nome;
            Nick = nick;
            Password = password;
            Pontos = pontos;
            CreatedDate = createdDate;
        }

        public Usuario(string nome, string nick, string password)
        {
            Nome = nome;
            Nick = nick;
            Password = password;
            Pontos = 0; // Valor padrão
            CreatedDate = DateTime.Now;
        }

        public Usuario() { }
    }
}

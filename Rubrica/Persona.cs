using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rubrica
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Indirizzo { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Foto { get; set; }

        public Persona() { }

        public Persona (string nome, string cognome, string indirizzo, string telefono, string email, string foto)
        {
            Nome = nome;
            Cognome = cognome;
            Indirizzo = indirizzo;
            Telefono = telefono;
            Email = email;
            Foto = foto;
        }
    }
}
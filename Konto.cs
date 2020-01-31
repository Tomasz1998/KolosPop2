using System;
using System.Collections.Generic;
using System.Text;

namespace KolosPop2
{
    public class Konto
    {
        private string _email;
        private readonly string _login;
        private string _haslo;
        private int _punkty;

        public Konto(string email, string login, string haslo)
        {
            _email = email;
            _login = login;
            _haslo = haslo;
            _punkty = 0;
        }
        public string Email { get; set; }
        public string Login => _login;
        public string Haslo { get; set; }
        public int Punkty { get; set; }
    }
}

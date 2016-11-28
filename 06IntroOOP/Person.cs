using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06IntroOOP
{
    public class Person
    {
        public string Fornavn;
        public string Efternavn;
        private int Alder;
        private string Adresse;

        // constructor ??
        public void InitialiserPerson(string fornavn, string efternavn,int alder, string adresse) {
            this.Fornavn = fornavn;
            this.Efternavn = efternavn;
            this.Alder = alder;
            this.Adresse = adresse;

        }

        public void GemIDatabase()
        {
            throw new System.NotImplementedException();
        }
    }
}
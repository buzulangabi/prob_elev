using System.Collections.Generic;
using System;
using System.Text;

namespace student
{
    public class DbCopchii
    {
        public List<Elev> GetCophii()
        {
           
            Elev elev = new Elev();
            elev.Nume = "Grey";
            elev.Prenume = "Christian";
            elev.IDNP = "2012012004459";
            elev.Clasa = 8;
            elev.DataNaserii = new DateTime(1998, 8, 11);
            elev.Genul = Gen.Masculin;
            elev.Adresa = new Address();

            elev.Adresa.Strada = "Central Park";
            elev.Adresa.Oras = "New York";
            elev.Adresa.Blocul = "121";
            elev.Adresa.Apartamentul = 85;


            Elev elev2 = new Elev
            {
                Nume = "Steel",
                Prenume = "Anastasia",
                IDNP = "2012012004458",
                Clasa = 6,
                DataNaserii = new DateTime(1997, 9, 15),
                Genul = Gen.Feminin,
                Adresa = new Address()
            };

            elev2.Adresa.Strada = "Broklyn";
            elev2.Adresa.Oras = "New York";
            elev2.Adresa.Blocul = "15";
            elev2.Adresa.Apartamentul = 5;

            Elev elev3 = new Elev();
            elev3.Nume = "Steel43";
            elev3.Prenume = "Anastasia43";
            elev3.IDNP = "2012012004458";
            elev3.Clasa = 6;
            elev3.DataNaserii = new DateTime(1900, 9, 15);
            elev3.Genul = Gen.Feminin;
            elev3.Adresa = new Address();

            elev3.Adresa.Strada = "Broklyn";
            elev3.Adresa.Oras = "New York";
            elev3.Adresa.Blocul = "15";
            elev3.Adresa.Apartamentul = 5;

            Elev elev4 = new Elev
            {
                Nume = "Steel",
                Prenume = "Anastasia",
                IDNP = "2012012004458",
                Clasa = 6,
                DataNaserii = new DateTime(1997, 1, 15),
                Genul = Gen.Feminin,
                Adresa = new Address()
            };

            Elev elev5 = new Elev
            {
                Nume = "Steel",
                Prenume = "Anastasia",
                IDNP = "2012012004458",
                Clasa = 6,
                DataNaserii = new DateTime(1987, 3, 25),
                Genul = Gen.Feminin,
                Adresa = new Address()
            };

            Elev elev6 = new Elev
            {
                Nume = "Steel",
                Prenume = "Anastasia",
                IDNP = "2012012004458",
                Clasa = 6,
                DataNaserii = new DateTime(2005, 6, 30),
                Genul = Gen.Masculin,
                Adresa = new Address()
            };


            var listaDeElevi = new List<Elev>();

            listaDeElevi.Add(elev);
            listaDeElevi.Add(elev3);
            listaDeElevi.Add(elev2);
            listaDeElevi.Add(elev4);
            listaDeElevi.Add(elev5);
            listaDeElevi.Add(elev6);

            return listaDeElevi;
        }

    }
}

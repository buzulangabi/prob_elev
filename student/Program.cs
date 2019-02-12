using System;
using System.Collections.Generic;

namespace student
{
    class Program
    {
        static void Main(string[] args)
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


            Elev elev2 = new Elev();
            elev2.Nume = "Steel";
            elev2.Prenume = "Anastasia";
            elev2.IDNP = "2012012004458";
            elev2.Clasa = 6;
            elev2.DataNaserii = new DateTime(2000, 9, 15);
            elev2.Genul = Gen.Feminin;
            elev2.Adresa = new Address();

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


            var listaDeElevi = new List<Elev>();

            listaDeElevi.Add(elev);
            listaDeElevi.Add(elev2);
            listaDeElevi.Add(elev3);

            int result = DateTime.Compare(elev.DataNaserii, elev2.DataNaserii);
            string relationship;

            if (elev.DataNaserii < elev2.DataNaserii)
            {
                //elev mai in varsta ca elev 2
            }
            else if(elev.DataNaserii > elev2.DataNaserii)
            {
                //elev2 ii mai in varsta
            }
            else
            {
                //deo seama
            }
            

            if (result < 0)
                relationship = "is earlier than";
            else if (result == 0)
                relationship = "is as the same time as";
            else
                relationship = "is later than";
            Console.WriteLine("{0} {1} {2}",elev.Nume, relationship, elev2.Nume);
            Console.ReadLine();

        }
    }
}

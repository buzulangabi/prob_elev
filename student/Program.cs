using System;
using System.Collections.Generic;

namespace student
{
    class Program


    {

        public static void Main(string[] args)
        {
            var dbCopii = new DbCopchii();


            List<Elev> listaDeElevi = dbCopii.GetCophii();

            var eleviiDeGenulMasculin = new List<Elev>();
            var eleviiDeGenulFeminin = new List<Elev>();

            //if (new List<Elev>().Count == 0)
            //{
            //    Console.WriteLine("EMPTY LIST");
            //    Console.ReadLine();
            //    //Environment.Exit(0);
            //};

            foreach (Elev elev in listaDeElevi)
            {
                if (elev.Genul == Gen.Masculin)
                {
                    eleviiDeGenulMasculin.Add(elev);
                }
                else
                {
                    eleviiDeGenulFeminin.Add(elev);
                }
            }


            foreach(Elev elevNume in eleviiDeGenulMasculin)
            {
                Console.WriteLine($"Elevii de genul masculin sunt: {elevNume.Nume}");
            }


            foreach (Elev elevNume in eleviiDeGenulFeminin)
            {
                Console.WriteLine($"Elevii de genul feminin sunt: {elevNume.Nume}");
            }







            //int result = DateTime.Compare(elev.DataNaserii, elev2.DataNaserii);
            //string relationship;

            //if (elev.DataNaserii < elev2.DataNaserii)
            //{
            //    //elev mai in varsta ca elev 2
            //}
            //else if(elev.DataNaserii > elev2.DataNaserii)
            //{
            //    //elev2 ii mai in varsta
            //}
            //else
            //{
            //    //deo seama
            //}


            //if (result < 0)
            //    relationship = "is earlier than";
            //else if (result == 0)
            //    relationship = "is as the same time as";
            //else
            //    relationship = "is later than";
            //Console.WriteLine("{0} {1} {2}",elev.Nume, relationship, elev2.Nume);
            //Console.ReadLine();

            var maxValue = (listaDeElevi[0]).DataNaserii;
            var minValue = (listaDeElevi[0]).DataNaserii;

            foreach (Elev e in listaDeElevi)
            {
                if (e.DataNaserii < maxValue)
                {
                    maxValue = e.DataNaserii;
                }

                else if (e.DataNaserii > minValue)
                {
                    minValue = e.DataNaserii;
                }

            }

            Console.WriteLine($"Elevul cel mai in varsta este: {maxValue}");
            Console.WriteLine($"Elevul cel mai mic este: {minValue}");
            Console.ReadLine();

            var secondmaxValue = (listaDeElevi[0]).DataNaserii;


            foreach (Elev e in listaDeElevi)
            {
                if (e.DataNaserii > maxValue && secondmaxValue > e.DataNaserii)
                {
                    secondmaxValue = e.DataNaserii;
                }
            }
            Console.WriteLine($"Al doilea cel mai in varsta elev: {secondmaxValue}");
            Console.ReadLine();
        }



    }
}

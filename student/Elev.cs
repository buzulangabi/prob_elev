using System;
using System.Collections.Generic;
using System.Text;

namespace student
{
    public class Elev
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public DateTime DataNaserii { get; set; }
        public Gen Genul { get; set; }
        public int Clasa { get; set; }
        public Address Adresa { get; set; }
        public string IDNP { get; set; }

    }

}

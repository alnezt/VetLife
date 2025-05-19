using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetLife.Core
{
    public class Animal
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Specie { get; set; }
        public string Rasa { get; set; }
        public int Varsta { get; set; }
        public double Greutate { get; set; }
        public int ProprietarId { get; set; }
        public string NumeProprietar { get; set; }
    }
}

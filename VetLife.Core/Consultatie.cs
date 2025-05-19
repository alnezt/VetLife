namespace VetLife.Core
{
    public class Consultatie
    {
        public int Id { get; set; }
        public int AnimalId { get; set; }
        public string NumeAnimal { get; set; }
        public string Data_consultatie { get; set; }
        public string Simptome { get; set; }
        public string Diagnostic { get; set; }
        public string Tratament { get; set; }
    }
}
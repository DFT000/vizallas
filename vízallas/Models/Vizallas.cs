namespace vízallas.Models
{
    public class Vizallas
    {
        public int Id { get; set; }
        public string Folyó { get; set; } = string.Empty;
        public string Település { get; set; } = string.Empty;
        public DateTime Datum { get; set; }
        public int VizallasErtek { get; set; }
    }
}

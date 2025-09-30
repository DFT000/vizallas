namespace Vizallas.Models.Dto
{
    public class OsszesitoDto
    {
        public string Település { get; set; } = string.Empty;
        public int MinErtek { get; set; }
        public DateTime MinDatum { get; set; }
        public int MaxErtek { get; set; }
        public DateTime MaxDatum { get; set; }
    }
}

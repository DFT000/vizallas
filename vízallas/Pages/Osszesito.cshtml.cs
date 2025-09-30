using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Vizallas.Data;
using Vizallas.Models.Dto;

namespace Vizallas.Pages
{
    public class OsszesitoModel : PageModel
    {
        private readonly VizallasContext _context;
        public OsszesitoModel(VizallasContext context) => _context = context;

        public string? ValasztottFolyó { get; set; }
        public List<OsszesitoDto> Eredmeny { get; set; } = new();

        [BindProperty(SupportsGet = true)]
        public string? Folyókeres { get; set; }

        public async Task OnGetAsync()
        {
            if (!string.IsNullOrEmpty(Folyókeres))
            {
                ValasztottFolyó = Folyó;

                Eredmeny = await _context.VizallasAdatok
                    .Where(v => v.Folyó == Folyókeres)
                    .GroupBy(v => v.Település)
                    .Select(g => new OsszesitoDto
                    {
                        Település = g.Key,
                        MinErtek = g.Min(x => x.VizallasErtek),
                        MinDatum = g.OrderBy(x => x.VizallasErtek).First().Datum,
                        MaxErtek = g.Max(x => x.VizallasErtek),
                        MaxDatum = g.OrderByDescending(x => x.VizallasErtek).First().Datum
                    })
                    .ToListAsync();
            }
        }
    }
}

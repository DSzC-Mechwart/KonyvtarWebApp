using System.ComponentModel.DataAnnotations;

namespace KonyvtarWebApp.Models{
class Konyv{
    public int Id{get; set;}

    [Required(ErrorMessage = "A cím megadása kötelező.")]
    [StringLength(100, ErrorMessage = "A cím maximum 100 karakter hosszú lehet.")]
    public string Cim { get; set; }

    [Required(ErrorMessage = "A szerző megadása kötelező.")]
    [StringLength(80, ErrorMessage = "A szerző maximum 80 karakter hosszú lehet.")]
    public string Szerzo { get; set; }

    [Display(Name = "Kiadás éve")]
    public int KiadasEve { get; set; }
    public decimal Ar { get; set; }
}
}
using System.ComponentModel.DataAnnotations;

namespace Hotellerie_Mehdi.Models.HotellerieModel
{
    public class Hotel
    {
    
        public int Id { get; set; }
        [Required(ErrorMessage = "ce champ est obligatoire ")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "set valid string")]
        public string Name { get; set; } = null!;
        [Range(1,5,ErrorMessage ="value between 1 and 5")]
        public  int Etoiles{ get; set; }
        [Required(ErrorMessage = "ce champ est obligatoire ")]
        public string Ville { get; set; } = null!;
        [Required,Url(ErrorMessage ="invalid url"),Display(Name="Site Web")]
        public string SiteWeb { get; set; }= null!;
        public string Tel { get; set; }
        public string Pays { get; set; }
        public virtual ICollection<Appreciation>? Appreciations { get; set; } 
    }
}

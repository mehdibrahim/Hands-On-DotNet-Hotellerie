using System.ComponentModel.DataAnnotations;

namespace Hotellerie_Mehdi.Models.HotellerieModel
{
    public class Appreciation
    {
        
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nom Personne")]
        public string NomPers   { get; set; } 
        [Required]
        [DataType(DataType.MultilineText)]
        public string Commentaire { get; set; } 
        public int HotelId { get; set; }
        [Required(ErrorMessage ="champs obligatoire")]
        [Range(1,5)]
        public int Note { get;set; }
        public virtual Hotel? Hotel { get; set; }
    }
}

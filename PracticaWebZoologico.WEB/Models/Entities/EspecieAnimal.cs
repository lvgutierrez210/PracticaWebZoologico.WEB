using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PracticaWebZoologico.WEB.Models.Entities
{
    public class EspecieAnimal
    {
        [Key]
        public int EspecieId { get; set; }
        [Required]
        public string NombreEspecie { get; set; }


        ////Propiedad de navegación a la entidad Animal
        //public ICollection<Animal> Animal { get; set; }
    }
}

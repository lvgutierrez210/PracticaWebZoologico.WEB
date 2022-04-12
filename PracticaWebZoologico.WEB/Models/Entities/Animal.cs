using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PracticaWebZoologico.WEB.Models.Entities
{
    public class Animal
    {
        [Key]
        public int NombreId { get; set; }

        [Required]  
        public string Nombre { get; set; }
        [Required]
        
        public int Edad { get; set; }


        //Propiedades de navegación y llaves foraneas
        [Required]
        public int ColorId { get; set; }//Llave foranea - ColorAnimal
        public virtual ColorAnimal ColorAnimal { get; set; }    //Propiedad de navegación -ColorAnimal(Relación de uno a muchos)

        [Required]
        public int EspecieId { get; set; }  //Llave foranea - EspecieAnimal
        public virtual EspecieAnimal EspecieAnimal { get; set; } //Propiedad de navegación -EspecieAnimal(Relación de uno a muchos)


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication2.Models
{
    public partial class tbcategoria
    {
        [MetadataType(typeof(itcategoria))]
        puntoencuentroEntities db = new puntoencuentroEntities();
        public void prueba2()
        {

        }


        public interface itcategoria
        {
            
            [Key]
            [ScaffoldColumn(false)] 
            object idcategoria { get; set; }

            
            [MinLengthAttribute(2)]
            object nombre { get; set; }


            [Required]
            object responsable { get; set; }


            [Required]
            object padre { get; set; }

            [DataType(DataType.DateTime, ErrorMessage = "debe introducir una fecha valida")]
            object fechacreacion { get; set; }

            [DataType(DataType.DateTime, ErrorMessage = "debe introducir una fecha valida")]
            object fechamodificacion { get; set; }

            [Required]
            object estado { get; set; }

            


        } 
    }
}
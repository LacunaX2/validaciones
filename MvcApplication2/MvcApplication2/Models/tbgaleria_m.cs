using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication2.Models
{
    public partial class tbgaleria
    {
        [MetadataType(typeof(itgaleria))]
        puntoencuentroEntities db = new puntoencuentroEntities();
        public void prueba2()
        {

        }


        public interface itgaleria
        {

            [Key]
            [ScaffoldColumn(false)]
            object idimagen { get; set; }

            [Required]
            [MinLengthAttribute(2)]
            object nombre { get; set; }


            [Required]
            [MinLengthAttribute(2)]
            object descripcion { get; set; }


            [Required]
            object idlugares { get; set; }
           

            [DataType(DataType.DateTime, ErrorMessage = "debe introducir una fecha valida")]
            object fechacreacion { get; set; }

            [DataType(DataType.DateTime, ErrorMessage = "debe introducir una fecha valida")]
            object fechamodificacion { get; set; }

            [Required]
            object estado { get; set; }




        }
    }
}
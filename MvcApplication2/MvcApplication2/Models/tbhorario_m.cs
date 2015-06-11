using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication2.Models
{
    public partial class tbhorario
    {
        [MetadataType(typeof(ithorario))]
        puntoencuentroEntities db = new puntoencuentroEntities();
        public void prueba2()
        {

        }


        public interface ithorario
        {

            [Key]
            [ScaffoldColumn(false)]
            object idhorario { get; set; }
            [DataType(DataType.DateTime)]
            object inicio { get; set; }
            [DataType(DataType.DateTime)]
            object fin { get; set; }

            [MinLengthAttribute(2)]
            object titulo { get; set; }


            [Required]
            object num_votes { get; set; }


            [Required]
            object idlugares { get; set; }
            [Required]
            object tipo { get; set; }
            

            [DataType(DataType.DateTime, ErrorMessage = "debe introducir una fecha valida")]
            object fechacreacion { get; set; }

            [DataType(DataType.DateTime, ErrorMessage = "debe introducir una fecha valida")]
            object fechamodificacion { get; set; }

            [Required]
            object estado { get; set; }




        } 
    }
}
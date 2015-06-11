using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication2.Models
{
    public partial class tbtelefonos
    {
        [MetadataType(typeof(ittelefonos))]
        puntoencuentroEntities db = new puntoencuentroEntities();
        public void prueba2()
        {

        }


        public interface ittelefonos
        {

            [Key]
            [ScaffoldColumn(false)]
            object idtelefonos { get; set; }


            [Required]
            object numero { get; set; }


            [Required]
            object tipo { get; set; }
            [Required]
            object codigoarea { get; set; }
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
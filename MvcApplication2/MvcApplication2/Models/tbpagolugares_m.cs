using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication2.Models
{
    public partial class tbpagolugares
    {
        [MetadataType(typeof(itpagolugares))]
        puntoencuentroEntities db = new puntoencuentroEntities();
        public void prueba2()
        {

        }


        public interface itpagolugares
        {

            [Key]
            [ScaffoldColumn(false)]
            object idligarpagos { get; set; }


            [Required]
            object idpago { get; set; }


            [Required]
            object idlugares { get; set; }

            [DataType(DataType.DateTime, ErrorMessage = "debe introducir una fecha valida")]
            object fecha { get; set; }

            [DataType(DataType.DateTime, ErrorMessage = "debe introducir una fecha valida")]
            object fechacreacion { get; set; }

            [DataType(DataType.DateTime, ErrorMessage = "debe introducir una fecha valida")]
            object fechamodificacion { get; set; }

            [Required]
            object estado { get; set; }




        } 
    }
}
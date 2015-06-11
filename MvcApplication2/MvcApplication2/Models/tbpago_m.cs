using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication2.Models
{
    public partial class tbpago
    {
        [MetadataType(typeof(itpago))]
        puntoencuentroEntities db = new puntoencuentroEntities();
        public void prueba2()
        {

        }


        public interface itpago
        {

            [Key]
            [ScaffoldColumn(false)]
            object idpago { get; set; }


            [MinLengthAttribute(2)]
            object nombre { get; set; }
            [MinLengthAttribute(2)]
            object imagen { get; set; }

            [DataType(DataType.DateTime, ErrorMessage = "debe introducir una fecha valida")]
            object fechacreacion { get; set; }

            [DataType(DataType.DateTime, ErrorMessage = "debe introducir una fecha valida")]
            object fechamodificacion { get; set; }

            [Required]
            object estado { get; set; }




        } 
    }
}
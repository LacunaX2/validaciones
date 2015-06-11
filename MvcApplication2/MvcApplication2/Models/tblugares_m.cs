using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication2.Models
{
    public partial class tblugares
    {
        [MetadataType(typeof(itlugares))]
        puntoencuentroEntities db = new puntoencuentroEntities();
        public void prueba2()
        {

        }


        public interface itlugares
        {

            [Key]
            [ScaffoldColumn(false)]
            object idlugar { get; set; }


            [MinLengthAttribute(2)]
            object titulo { get; set; }
            [MinLengthAttribute(2)]
            object direccion { get; set; }
            [MinLengthAttribute(2)]
            object descripcion { get; set; }
            [MinLengthAttribute(2)]
            object web { get; set; }
            [Required]
            object imagen { get; set; }
            [EmailAddress]
            object email{ get; set; }

            [Required]
            object lat { get; set; }
            [Required]
            object llong { get; set; }


            [DataType(DataType.DateTime, ErrorMessage = "debe introducir una fecha valida")]
            object fechacreacion { get; set; }

            [DataType(DataType.DateTime, ErrorMessage = "debe introducir una fecha valida")]
            object fechamodificacion { get; set; }

            [Required]
            object estado { get; set; }




        } 
    }
}
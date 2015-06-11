using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication2.Models
{
    public partial class tbvotousuario
    {
        [MetadataType(typeof(itvotousuario))]
        puntoencuentroEntities db = new puntoencuentroEntities();
        public void prueba2()
        {

        }


        public interface itvotousuario
        {

            [Key]
            [ScaffoldColumn(false)]
            object idvotousuario { get; set; }


            [Required]
            object idlugar { get; set; }


            [Required]
            object iduser { get; set; }


            [Required]
            object score { get; set; }

            [DataType(DataType.DateTime, ErrorMessage = "debe introducir una fecha valida")]
            object fechacreacion { get; set; }

            [DataType(DataType.DateTime, ErrorMessage = "debe introducir una fecha valida")]
            object fechamodificacion { get; set; }

            [Required]
            object estado { get; set; }




        } 
    }
}
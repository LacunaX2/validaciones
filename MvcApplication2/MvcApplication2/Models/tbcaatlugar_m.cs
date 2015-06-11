using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace MvcApplication2.Models
{
    public partial class tbcatlugar
    {
        [MetadataType(typeof(itcatlugar))]
        puntoencuentroEntities db = new puntoencuentroEntities();
        public void prueba2()
        {

        }


        public interface itcatlugar
        {

            [Key]
            [ScaffoldColumn(false)]
            object idcatlugares { get; set; }


            [Required]
            object idcategorias { get; set; }



            [DataType(DataType.DateTime, ErrorMessage = "debe introducir una fecha valida")]
            object fechacreacion { get; set; }

            [DataType(DataType.DateTime, ErrorMessage = "debe introducir una fecha valida")]
            object fechamodificacion { get; set; }

            [Required]
            object estado { get; set; }




        } 
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication2.Models
{
    public partial class tb_lugar_voto
    {
        [MetadataType(typeof(itlugar))]
        puntoencuentroEntities db = new puntoencuentroEntities();
        public void prueba2()
        {

        }


        public interface itlugar
        {

            [Key]
            [ScaffoldColumn(false)]
            object idvoto { get; set; }


            [MinLengthAttribute(2)]
            object titulo { get; set; }


            [Required]
            object num_votes { get; set; }


            [Required]
            object total_score { get; set; }
            [Required]
            object rating { get; set; }
            [Required]
            [Range(600000, 900000)]
            object id { get; set; }

            [DataType(DataType.DateTime, ErrorMessage = "debe introducir una fecha valida")]
            object fechacreacion { get; set; }

            [DataType(DataType.DateTime, ErrorMessage = "debe introducir una fecha valida")]
            object fechamodificacion { get; set; }

            [Required]
            object estado { get; set; }




        } 
    }
}
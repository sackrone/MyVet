using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Data.Entities
{
    public class Agenda
    {
        public int Id { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd H:mm tt", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Date")]
        public DateTime Date { get; set; }

        public string Remarks { get; set; }

        [Display(Name = "Is Available")]
        public bool IsAvailable { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd H:mm tt}")]
        [Display(Name = "Date")]
        public DateTime DateLocal => Date.ToLocalTime();
    }
}

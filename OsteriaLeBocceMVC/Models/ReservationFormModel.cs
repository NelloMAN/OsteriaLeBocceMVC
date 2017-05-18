using System;
using System.ComponentModel.DataAnnotations;
using Umbraco.Web.Mvc;

namespace OsteriaLeBocceMVC.Models
{
    public class ReservationFormModel 
    {
        [Required(ErrorMessage = "Il nome è obbligatorio")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Il cognome è obbligatorio")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "La data è obbligatoria")]
        [DataType(DataType.Date, ErrorMessage = "Data non valida")]
        [DisplayFormat(DataFormatString = "{dd/MM/yyyy HH:mm}")]
        [DayValidation]
        public DateTime Day { get; set; }

        [Required(ErrorMessage = "Inserire il numero di persone")]
        [Range(1,20)]
        public int Persons { get; set; }

        [Required(ErrorMessage = "Inserire un numero di telefono per la conferma")]
        [Phone(ErrorMessage = "Numero di telefono non valido")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Numero di telefono non valido")]
        public string Telephone { get; set; }

        [Required(ErrorMessage = "Inserire una email per la conferma")]
        [EmailAddress(ErrorMessage = "Email non valida")]
        public string Email { get; set; }

        public string Menu { get; set; }

        public string Evento { get; set; }

        public string Message { get; set; }

        //public override void Execute()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
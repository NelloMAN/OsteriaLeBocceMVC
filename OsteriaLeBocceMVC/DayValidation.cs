using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OsteriaLeBocceMVC
{
    public class DayValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext reservationModel)
        {
            if (value != null)
            {
                DateTime date = Convert.ToDateTime( value.ToString());

                TimeSpan pranzoDa = TimeSpan.Parse("11:59");
                TimeSpan pranzoA = TimeSpan.Parse("14:01");
                TimeSpan cenaDa = TimeSpan.Parse("18:59");
                TimeSpan cenaA = TimeSpan.Parse("22:01");

                if ( DateTime.Compare(date, DateTime.Now) > 0 && date.DayOfWeek != DayOfWeek.Tuesday)
                {
                    if (TimeSpan.Compare(date.TimeOfDay, pranzoDa) > 0 && TimeSpan.Compare(date.TimeOfDay, pranzoA) < 0 || TimeSpan.Compare(date.TimeOfDay, cenaDa) > 0 && TimeSpan.Compare(date.TimeOfDay, cenaA) < 0)
                    {                        
                        return  ValidationResult.Success;
                    } else
                    {
                        return new ValidationResult("Inserire un'ora valida");
                    }

                }
                else
                {
                    
                    return new ValidationResult("Inserire una data che non sia passata o che non sia un martedì");
                }
            }
            else
            {
                return new ValidationResult("Inserire una data valida");
            }
        }

    }
}
using OsteriaLeBocceMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace OsteriaLeBocceMVC.Controller
{
    public class ReservationFormSurfaceController : SurfaceController
    {
        // GET: ReservationFormSurface
        public ActionResult Index()
        {
            var model = new OsteriaLeBocceMVC.Models.ReservationFormModel();
            return PartialView("ReservationForm", model);
        }

        [HttpPost]
        public ActionResult HandleFormSubmit(ReservationFormModel reservationModel) {

            //CheckReservationForm(model);

            if (ModelState.IsValid)
            {

                try
                {
                    MailMessage message = new MailMessage();
                    message.To.Add("osteria.lebocce@gmail.com");
                    message.Subject = "Nuova prenotazione dal sito Osteria Le Bocce!";
                    message.From = new System.Net.Mail.MailAddress(reservationModel.Email, reservationModel.Name);

                    string note = "";

                    if (reservationModel.Message == null || reservationModel.Message.Trim().Equals(""))
                    {
                        note = "Non ci sono note aggiuntive";
                    }
                    else
                    {
                        note = "Note aggiuntive: " + reservationModel.Message;
                    }

                    message.Body = "Prenotazione effettuata da: " + reservationModel.Name + " " + reservationModel.Surname + " per " + reservationModel.Persons + " persone \n" +
                                   "per il giorno " + reservationModel.Day.Date.ToString("dd/MM/yyyy") + " alle ore " + reservationModel.Day.TimeOfDay.ToString(@"hh\:mm") + " \n" +
                                   "Confermare al numero: " + reservationModel.Telephone + " o all'e-mail: " + reservationModel.Email + "\n" +
                                   "" + note;

                    SmtpClient smtp = new SmtpClient();
                    smtp.Credentials = new System.Net.NetworkCredential("osteria.lebocce@gmail.com", "salerno54");
                    smtp.Port = 587;
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;
                    smtp.Send(message);

                    TempData["success"] = true;
                }
                catch (Exception e)
                {
                    TempData["success"] = false;
                }

                return RedirectToCurrentUmbracoPage();
            }
            else {
                return CurrentUmbracoPage();
                
            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.ViewModels
{
    public class ContactUsViewModel
    {
        
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "No has ingresado tu nombre completo.")]
        public string fullName { set; get; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "No has ingresado tu numero de telefono.")]
        public string phone { set; get; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "No has ingresado tu correo electronico.")]
        public string mail { set; get; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "No has ingresado tu mensaje.")]
        public string message { set; get; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "No has ingresado el de tu empresa.")]
        public string enterprise { set; get; }
    }
}
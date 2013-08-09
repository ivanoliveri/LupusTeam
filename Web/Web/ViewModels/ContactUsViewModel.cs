using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.ViewModels
{
    public class ContactUsViewModel
    {
        public string fullName { set; get; }

        public string phone { set; get; }

        public string mail { set; get; }

        [DataType(DataType.MultilineText)]
        public string message { set; get; }

        public string enterprise { set; get; }
    }
}
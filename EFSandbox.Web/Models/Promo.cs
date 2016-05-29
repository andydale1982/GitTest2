using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EFSandbox.Web.Models
{
    public class Promo
    {
        public int PromoID { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public Link Link { get; set; }
    }
}
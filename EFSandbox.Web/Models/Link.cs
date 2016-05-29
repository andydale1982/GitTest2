using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFSandbox.Web.Models
{
    public class Link
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public bool NewWindow { get; set; }
    }
}
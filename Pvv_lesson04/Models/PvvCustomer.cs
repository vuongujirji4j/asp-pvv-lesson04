using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pvv_lesson04.Models
{
    public class PvvCustomer
    {
        public int Customer { get; set; }
        public string firstname {  get; set; }
        public string lastname { get; set; }
        public string address { get; set; }
        public int YearOfBirth { get; set; }
    }
}
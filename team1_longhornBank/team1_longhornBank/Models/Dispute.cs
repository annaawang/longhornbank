using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace team1_longhornBank.Models
{
    public class Dispute
    {
        public Int32 DisputeID { get; set; }

        public bool Status { get; set; }

        public String Message { get; set; }

        public Decimal DipustedAmount { get; set; }
    }
}
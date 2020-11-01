﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ghasedak.ViewModel
{
    public class BoxViewModel
    {
         public string number { get; set; }
         public string code { get; set; }

        public string fullName { get; set; }

        public string mobile { get; set; }

        public string assignmentDate { get; set; }
        public string address { get; set; }
        public double lon { get; set; }
        public double lat { get; set; }
        public int dischargeRouteId { get; set; }

    }
}
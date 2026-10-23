using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagment.Model
{
    public class WebinarsItem
    {
        public string WebinarCode { get; set; }
        public string WebinarName { get; set; }
        public decimal TotalHour { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }

    }
}

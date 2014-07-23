using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuctionSite.Models
{
    public class Auction
    {
        public int AuctionID { get; set; }

        public int UserID { get; set; }
        public virtual User User { get; set; }

        public String Description { get; set; }
        public String ImageUrl { get; set; }
        public DateTime FromTime { get; set; }
        public DateTime ToTime { get; set; }
        public float StartRate { get; set; }

        public int WinneUniqID { get; set; }
    }
}
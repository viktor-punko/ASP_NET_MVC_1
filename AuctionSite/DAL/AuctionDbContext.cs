using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using AuctionSite.Models;

namespace AuctionSite.DAL
{
    public class AuctionDbContext: System.Data.Entity.DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Auction> Auctions { get; set; }

        //AuctionSite.DAL.AuctionDbContext
        public AuctionDbContext()
            : base("AuctionSiteDatabase")
        {

        }
    }
}
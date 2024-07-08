using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PRS_Server.Models;

namespace PRS_Server.Data
{
    public class PRS_ServerContext : DbContext
    {
        public PRS_ServerContext (DbContextOptions<PRS_ServerContext> options)
            : base(options)
        {
        }

        public DbSet<PRS_Server.Models.User> User { get; set; } = default!;
        public DbSet<PRS_Server.Models.Vendor> Vendor { get; set; } = default!;
        public DbSet<PRS_Server.Models.Product> Product { get; set; } = default!;
        public DbSet<PRS_Server.Models.Request> Request { get; set; } = default!;
        public DbSet<PRS_Server.Models.RequestLine> RequestLine { get; set; } = default!;
    }
}

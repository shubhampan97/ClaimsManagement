using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemberPortal.Models
{
    public class MockDbPolicyContext : DbContext
    {
        public MockDbPolicyContext(DbContextOptions<MockDbPolicyContext> options) : base(options) { }

        public DbSet<MockDatabasePolicy> NewMockDatabasesPolicy { get; set; }


    }
}

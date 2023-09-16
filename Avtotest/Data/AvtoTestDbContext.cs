﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Avtotest.Data
{
    public class AvtoTestDbContext : IdentityDbContext
    {
        public AvtoTestDbContext(DbContextOptions<AvtoTestDbContext> options)
            : base(options)
        {
            
        }
    }
}

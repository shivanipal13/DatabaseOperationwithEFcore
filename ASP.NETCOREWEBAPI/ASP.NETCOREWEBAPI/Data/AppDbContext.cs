﻿using Microsoft.EntityFrameworkCore;
namespace ASP.NETCOREWEBAPI.Data

{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

    }
}

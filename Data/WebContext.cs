using Microsoft.EntityFrameworkCore;
using aspLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspLogin.Data
{
    public class WebContext: DbContext
    {
        public WebContext(DbContextOptions<WebContext> options) : base(options) { }

        public DbSet<UserModel> Usuarios { get; set; }

    }
}
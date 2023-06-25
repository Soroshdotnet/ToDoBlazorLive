using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToDoBlazor2.Shared.Entities;

namespace ToDoBlazor2.API.Data
{
    public class APIContext : DbContext
    {
        public APIContext (DbContextOptions<APIContext> options)
            : base(options)
        {
        }

        public DbSet<ToDoBlazor2.Shared.Entities.Item> Item { get; set; } = default!;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace WebApplicationNancy.Models
{
    public class PersonasContext : DbContext
    {
        public PersonasContext (DbContextOptions<PersonasContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationNancy.Models.Persona> Persona { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using Project.Core.Models;
using Project.EF.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.EF
{
    public class EntityContext:DbContext
    {
         public EntityContext(DbContextOptions<EntityContext> options):base(options)
        {

        }
       
        public DbSet<Student> Students { get; set; }

    }
}

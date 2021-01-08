using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JewleryAPI.Modal
{
    public class JweleryDBContex : DbContext
    {
        public JweleryDBContex(DbContextOptions<JweleryDBContex> option) : base(option)
        {

        }
        public DbSet<User> User { get; set; }
    }
}

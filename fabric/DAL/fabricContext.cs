using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class fabricContext :DbContext
    {
        public fabricContext(DbContextOptions options) : base(options) { 
        
        }
        public DbSet<User> Users { get; set; }
    }
}

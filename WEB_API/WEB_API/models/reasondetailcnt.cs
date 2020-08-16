using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WEB_API.models
{
    public class reasondetailcnt:DbContext
    {

        public reasondetailcnt(DbContextOptions<reasondetailcnt>options):base(options)
        {
           

        }
        public DbSet<reasondetail> reasondetails { get; set; }
        
       
    }
}

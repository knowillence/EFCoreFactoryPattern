using Knowillence.Yaapiyal.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knowillence.Yaapiyal
{
    public class YaapiyalDBContext : DbContext
    {
        public YaapiyalDBContext(DbContextOptions<YaapiyalDBContext> options) : base (options)
        {
            
        }

        public DbSet<ref_record_status> ref_record_status { get; set; }
    }
}

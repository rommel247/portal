using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using portal.api.Data.Entities;
namespace portal.api.Data
{
    public class ArtContext : DbContext
    {
        public ArtContext(DbContextOptions<ArtContext> options) : base(options)
        {
        }
        //TODO: here are the  DBSet<entities>
    }
}

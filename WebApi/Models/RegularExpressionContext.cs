using Microsoft.EntityFrameworkCore;

namespace WebApi.Models
{
    public class RegularExpressionContext : DbContext
    {
        public RegularExpressionContext(DbContextOptions<RegularExpressionContext> options)
            : base(options)
        {
        }

        public DbSet<RegularExpressionGroup> RegularExpressionGroups { get; set; }
        public DbSet<RegularExpression> RegularExpressions { get; set; }
    }
}

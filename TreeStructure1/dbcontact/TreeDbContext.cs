using Microsoft.EntityFrameworkCore;
using TreeStructure1.Model;

namespace TreeStructure1.dbcontact
{
    public class TreeDbContext : DbContext
    {
        
 
    
        public TreeDbContext(DbContextOptions<TreeDbContext> options) : base(options)
        {
        }
        public DbSet<TreeNode> TreeNodes { get; set; }
    }
}


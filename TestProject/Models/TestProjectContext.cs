using Microsoft.EntityFrameworkCore;

namespace TestProject.Models;

public class TestProjectContext : DbContext
{

    public TestProjectContext(DbContextOptions<TestProjectContext> options) : base(options)
    {

    }
    public virtual DbSet<User> Users { get; set; }

}
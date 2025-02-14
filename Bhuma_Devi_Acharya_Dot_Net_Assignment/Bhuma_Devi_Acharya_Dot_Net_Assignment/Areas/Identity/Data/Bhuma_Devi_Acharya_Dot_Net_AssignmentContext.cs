using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Bhuma_Devi_Acharya_Dot_Net_Assignment.Models;

namespace Bhuma_Devi_Acharya_Dot_Net_Assignment.Data;

public class Bhuma_Devi_Acharya_Dot_Net_AssignmentContext : IdentityDbContext<IdentityUser>
{
    public Bhuma_Devi_Acharya_Dot_Net_AssignmentContext(DbContextOptions<Bhuma_Devi_Acharya_Dot_Net_AssignmentContext> options)
        : base(options)
    {
    }
    public DbSet<TeacherLeave> TeacherLeaves { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}

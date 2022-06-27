using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NoticeBoardApp.Data.Configurations;
using NoticeBoardApp.Models;

namespace NoticeBoardApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Notice> Notices { get; set; }
        public DbSet<NoticeViewer> NoticeViewers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ApplyNoticeViewerEntityConfiguration());
        }
    }
}
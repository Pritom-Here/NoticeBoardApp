using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NoticeBoardApp.Models;

namespace NoticeBoardApp.Data.Configurations
{
    public class ApplyNoticeViewerEntityConfiguration : IEntityTypeConfiguration<NoticeViewer>
    {
        public void Configure(EntityTypeBuilder<NoticeViewer> builder)
        {
            builder.HasKey(nv => new { nv.NoticeId, nv.UserId });

            builder
                .HasOne(nv => nv.Notice)
                .WithMany(nv => nv.NoticeViewers)
                .HasForeignKey(nv => nv.NoticeId)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasOne(nv => nv.User)
                .WithMany(nv => nv.NoticeViewers)
                .HasForeignKey(nv => nv.UserId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}

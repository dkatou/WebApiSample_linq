using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using dk.A1.S1.UserMng.UserMngModel.Models;

namespace dk.A1.S1.UserMng.UserMngModel.Datas.Configs
{
    public class UserProfileConfig : IEntityTypeConfiguration<UserProfile>
    {
        public void Configure(EntityTypeBuilder<UserProfile> builder)
        {
            builder
                .ToTable("T_USER_PROFILE")
                .HasKey(keyExpression => keyExpression.UserId);
        }
}
}
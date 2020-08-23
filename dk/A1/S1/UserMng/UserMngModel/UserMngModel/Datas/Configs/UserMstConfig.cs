using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using dk.A1.S1.UserMng.UserMngModel.Models;

namespace dk.A1.S1.UserMng.UserMngModel.Datas.Configs
{
    public class UserMstConfig : IEntityTypeConfiguration<UserMst>
    {
        public void Configure(EntityTypeBuilder<UserMst> builder)
        {
            builder
                .ToTable("M_USER")
                .HasKey(keyExpression => keyExpression.UserId);
        }
    }
}
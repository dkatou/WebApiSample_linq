using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using dk.A1.S1.UserMng.UserMngModel.Models;

namespace dk.A1.S1.UserMng.UserMngModel.Datas.Configs
{
    public class UserRoleSettingConfig : IEntityTypeConfiguration<UserRoleSetting>
    {
        public void Configure(EntityTypeBuilder<UserRoleSetting> builder)
        {
            builder
                .ToTable("T_USER_ROLE_SETTING")
                .HasKey(keyExpression => new {
                    keyExpression.UserId,
                    keyExpression.RoleId
                    });
    }
    }
}
using System.ComponentModel.DataAnnotations.Schema;

namespace dk.A1.S1.UserMng.UserMngModel.Models
{
    public class UserRoleSetting
    {
        [Column("V_USER_ID")]
        public long UserId { get; set; }

        [Column("V_ROLE_ID")]
        public long RoleId { get; set; }
    }
}
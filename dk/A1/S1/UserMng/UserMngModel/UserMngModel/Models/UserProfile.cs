using System.ComponentModel.DataAnnotations.Schema;

namespace dk.A1.S1.UserMng.UserMngModel.Models
{
    public class UserProfile
    {
        [Column("V_USER_ID")]
        public long UserId { get; set; }

        [Column("NV_USER_NAME", TypeName = "nvarchar(200)")]
        public string UserName { get; set; }
    }
}
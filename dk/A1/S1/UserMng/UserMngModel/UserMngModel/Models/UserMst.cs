using System.ComponentModel.DataAnnotations.Schema;

namespace dk.A1.S1.UserMng.UserMngModel.Models
{
    public class UserMst
    {
        [Column("V_USER_ID")]
        public long UserId { get; set; }

        [Column("V_COM_ID")]
        public long ComId { get; set; }
    }
}
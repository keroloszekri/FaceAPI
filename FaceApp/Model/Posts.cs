using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FaceApp.Model
{
    public class Posts
    {
        [Key]
        [Required]
        public int ID { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }


        public String UserID { get; set; }
        [ForeignKey("UserID")]
        public virtual ApplicationUser User { get; set; }



    }
}

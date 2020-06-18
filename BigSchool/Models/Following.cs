using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BigSchool.Models
{
    public class Following
    {
        [Key]
        [Column(Order =1)]
        public string FolloweerId { get; set; }

        [Key]
        [Column(Order = 2)]
        public string FolloweeId { get; set; }

        public ApplicationUser Flolower { get; set; }
        public ApplicationUser Follwee { get; set; }
    }
}
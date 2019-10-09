//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiFvj.Models.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Comment : BaseEntity
    {
        [Required]
        public int UserId { get; set; }

        [Required]
        public int LeadId { get; set; }

        [Required]
        [StringLength(150, MinimumLength = 5)]
        public string Text { get; set; }

        [Required]
        [Range(0, 1)]
        public int Active { get; set; }

        [Required]
        public System.DateTime Createdat { get; set; }

        public virtual User User { get; set; }
        public virtual Lead Lead { get; set; }
    }
}

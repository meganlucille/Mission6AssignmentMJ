using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6AssignmentMJ.Models
{
    public class MovieEntry
    {
        [Key]
        [Required]
        public int EntryID { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public short Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        [Display(Name = "Rating")]
        [EnumDataType(typeof(MovieRating))]
        public MovieRating Rating { get; set; }

        public bool Edited { get; set; }

        public int LentTo { get; set; }

        [StringLength(25)]
        public string Notes { get; set; }
    }
    public enum MovieRating
    {
        G,
        PG,
        PG_13,
        R
    }
}

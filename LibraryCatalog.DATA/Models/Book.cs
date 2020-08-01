using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryCatalog.DATA.Models 
{
    public class Book
    {
        [Key]
        public string name {get; set;}

        [Required]
        public DateTime postDate {get; set;}

        [ForeignKey(nameof(Author))]
        public int authorId {get; set;}

    }
}
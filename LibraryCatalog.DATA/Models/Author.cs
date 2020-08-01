using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryCatalog.DATA.Models 
{
    public class Author
    {
        public Author(){
            this.Books = new List<Book>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get; set;}

        [Required]
        public string name { get; set;}
        
        [Required]
        public int age{ get; set; }

        public ICollection<Book> Books {get; set;}
    }
}
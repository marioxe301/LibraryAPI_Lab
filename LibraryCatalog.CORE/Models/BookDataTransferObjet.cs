using System;
namespace LibraryCatalog.CORE.Models
{
    public class BookDataTransferObjet
    {
        public string name { get; set; }

        public DateTime postDate { get; set; }

        public int authorId { get; set; }

        public string AuthorName { get; set; }
    }
}

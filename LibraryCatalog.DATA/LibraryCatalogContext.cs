using Microsoft.EntityFrameworkCore;
using LibraryCatalog.DATA.Models;

namespace LibraryCatalog.DATA
{
    public class LibraryCatalogContext: DbContext 
    {
        //Tablas de nuestra base de datos
        DbSet<Author> Author { get; set;}

        DbSet<Book> Book { get; set; }

        //configuracion de la base de datos
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=Library.db");
    }
}

using Microsoft.EntityFrameworkCore;
using BibliotecaMonolito.Models;

namespace BibliotecaMonolito;
{
public class LibraryDbContext : DbContext
{
    public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
    {
    }
    public DbSet<Autor> Autores { get; set; } = null!;
    public DbSet<Libro> Libros { get; set; } = null!;

}
}
namespace Mission_11Watts.Models;

public interface IBookRepository
{
    public IQueryable<Book> Books { get; }
}
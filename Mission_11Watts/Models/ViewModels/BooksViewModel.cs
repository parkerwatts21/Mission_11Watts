namespace Mission_11Watts.Models.ViewModels;

public class BooksViewModel
{
    public IQueryable<Book> Books { get; set; }
    public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();
}
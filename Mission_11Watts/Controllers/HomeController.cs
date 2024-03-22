using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission_11Watts.Models;
using Mission_11Watts.Models.ViewModels;

//using Mission_11Watts.Models;

namespace Mission_11Watts.Controllers;

public class HomeController : Controller
{
    private IBookRepository _repo;
    
    public HomeController(IBookRepository temp)
    {
        _repo = temp;
    }

    public IActionResult Index(int pageNum)
    {
        int pageSize = 10;
        var blah = new BooksViewModel
        {
            Books = _repo.Books
                .OrderBy(x => x.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

            PaginationInfo = new PaginationInfo
            {
                CurrentPage = pageNum,
                ItemsPerPage = 10,
                TotalItems = _repo.Books.Count(),

            }
        };
        
        return View(blah);
    }
}
using asp_blog_app.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp_blog_app.Controllers;

public class BlogController : Controller
{
    private readonly AppDbContext _context;

    public BlogController(AppDbContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        var posts = _context.BlogPosts
                            .OrderByDescending(p => p.CreatedAt)
                            .ToList();
        return View(posts);
    }
    public IActionResult Details(int id)
    {
        var post = _context.BlogPosts.FirstOrDefault(p => p.Id == id);
        if (post == null) return NotFound();

        return View(post);
    }
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(BlogPost post)
    {
        if (ModelState.IsValid)
        {
            post.CreatedAt = DateTime.Now;
            _context.BlogPosts.Add(post);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(post);
    }
}
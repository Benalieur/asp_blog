using System.ComponentModel.DataAnnotations;
namespace asp_blog_app.Models;

public class BlogPost
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Le Titre est obligatoire.")]
    public required string Title { get; set; }

    [Required(ErrorMessage = "Le Contenu est obligatoire.")]
    public required string Content { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    [Required(ErrorMessage = "L'Auteur est obligatoire.")]
    public required string Author { get; set; }

    public BlogPost() { }

    // public BlogPost(string title, string content, string author)
    // {
    //     Title = title ?? throw new ArgumentNullException(nameof(title));
    //     Content = content ?? throw new ArgumentNullException(nameof(content));
    //     Author = author ?? throw new ArgumentNullException(nameof(author));
    //     CreatedAt = DateTime.Now;
    // }

}
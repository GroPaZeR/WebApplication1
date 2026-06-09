using Microsoft.AspNetCore.Mvc.RazorPages;
using ClassLibrary;

public class IndexModel : PageModel
{
    public Article Article { get; set; }
    public string Title { get; set; }
    public void OnPost()
    {
    }
    public void OnGet()
    {
        News news = new News();
        news.ReadArticles();
        Article = news.RandomAricle();
    }
}
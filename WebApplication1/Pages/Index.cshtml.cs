using Microsoft.AspNetCore.Mvc.RazorPages;
using ClassLibrary;

public class IndexModel : PageModel
{
    public Article Article { get; set; }

    public void OnGet()
    {
        News news = new News();

        // загрузка статей...

        news.readArticles();
        Article = news.RandomAricle();
    }
}
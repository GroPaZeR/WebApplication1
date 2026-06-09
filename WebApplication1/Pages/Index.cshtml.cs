using Microsoft.AspNetCore.Mvc.RazorPages;
using ClassLibrary;

public class IndexModel : PageModel
{
    public Article Article { get; set; }
    public List<Article> sideArticles = new List<Article>();
    public void OnPost()
    {
    }
    public void OnGet()
    {
        News news = new News();
        news.ReadArticles();
        Article = news.RandomAricle();
        //Добавление последних 5 статей по возрастанию
        for (int i = news.articles.Count - 1; i > 0; i--)
        {
            sideArticles.Add(news.articles[i]);
        }
    }
}
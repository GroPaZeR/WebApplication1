using Microsoft.AspNetCore.Mvc.RazorPages;
using ClassLibrary;


public class OneCategoryNewsModel : PageModel
{
    static public string NewsCategory { get; set; }
    static public Article[] nineArticles = new Article[9];
    public void OnGet(string category)
    {
        NewsCategory = category;
        News news = new News();

        news.ReadArticles();

        for (int i = news.articles.Count - 1, j = 0; i >= 0; i--)
        {
            if (news.articles[i].theme == NewsCategory)
            {
                nineArticles[j] = news.articles[i];
                j++;
            }
        
        }
        

    }
}
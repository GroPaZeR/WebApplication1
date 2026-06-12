using ClassLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


public class OneThemeModel : PageModel
{
    public string Theme {  get; set; }
    public Article[] Articles { get; set; }
    public void OnGet(string category)
    {
        Theme = category;
        Articles = GetTwelfeArticles();
    }

    private Article[] GetTwelfeArticles()
    {
        Article[] twelfeArticles = new Article[12];

        News news = new News();
        news.ReadArticles();

        for (int i = 0, j = 0; i < news.articles.Count; i++)
        {
            if (news.articles[i].theme == Theme)
            {
                twelfeArticles[j] = news.articles[i];
                j++;
            }
        }

        return twelfeArticles;
    }
}

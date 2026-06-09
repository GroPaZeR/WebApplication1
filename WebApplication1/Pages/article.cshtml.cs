using ClassLibrary;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;
using IOFile = System.IO.File;

    public class articleModel : PageModel
    {
        public readonly static string newsDataPath = @"NewsDatabase.Json";
        public string articleId {  get; set; }
        public Article selectedArticle = new Article();
        public void OnGet(string id)
        {
            articleId = id;
            //поиск статьи
            //разметка на странице нужной
            FindArticle(articleId);
        }

        public void FindArticle(string id)
        {
            string json = System.IO.File.ReadAllText(newsDataPath);
            List<Article> articles = JsonSerializer.Deserialize<List<Article>>(json)
                       ?? new List<Article>();

            foreach (Article article in articles)
            {
                if (article.id == id)
                {
                    selectedArticle = article;
                    break;
                }
            }
        }
    }


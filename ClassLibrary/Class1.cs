using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace ClassLibrary
{
    public class News
    {
        public readonly static string newsDataPath = @"NewsDatabase.Json";
        public List<Article> articles = new List<Article>();

        public Article RandomAricle()
        {
            Article randomArticle;

            Random rnd = new Random();

            randomArticle = articles[rnd.Next(0,articles.Count)];

            return randomArticle;
        }
        public void ReadArticles()
        {
            string json = File.ReadAllText(newsDataPath);

            articles = JsonSerializer.Deserialize<List<Article>>(json)?? new List<Article>();
        }

        public static void WriteArticles(Article article)
        {
            //Читаем данные из json
            string json = File.ReadAllText(newsDataPath);
            List<Article> articles = JsonSerializer.Deserialize<List<Article>>(json)
                       ?? new List<Article>();

            //Добавляем новую статью
            articles.Add(article);


            //Записываем новый список в файл
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            string jsonArticles = JsonSerializer.Serialize(articles, options);

            File.WriteAllText(newsDataPath, jsonArticles);
        }
    }
    public class Article
    {
        public string title { get; set; }
        public string id { get; set; }
        public string text { get; set; }
        public string date { get; set; }
        public string theme { get; set; }
        public string articleImage {  get; set; }
    }
}

using System.Text;
using System.Text.Json;

namespace ClassLibrary
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Id { get; set; }

    }
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
        public void readArticles()
        {
            string[] jsonarticles = File.ReadAllLines(newsDataPath);
            for (int i = 0; i < jsonarticles.Length; i++)
            {
                articles.Add(JsonSerializer.Deserialize<Article>(jsonarticles[i]));

            }
        }

        public static void writeArticles()
        {
            News news = new News();/*
            news.articles.Add(new Article()
            {
                title = "Кубок Республики Беларусь по мотокроссу  прошел в Иваново",
                text = "Пыль, жара, рёв моторов и безумные полёты в воздухе. Вот что происходило в Иваново с 1 по 3 мая, когда там прошёл третий этап республиканских соревнований по мотокроссу. Трасса кипела, гонщики сражались за каждую секунду — и у нас есть чем поделиться с теми, кто не смог быть на трибунах.",
                date = new DateTime(2026, 06, 07)
            });*/

            string[] newsasJson = new string[news.articles.Count];
            for (int i = 0; i < news.articles.Count; i++)
            {
                newsasJson[i] = JsonSerializer.Serialize(news.articles[i]);
            }
            Encoding encoding = Encoding.Unicode;
            File.AppendAllLines(newsDataPath, newsasJson, encoding);
        }
    }
    public class Article
    {
        public string title { get; set; }
        public int id { get; set; }
        public string text { get; set; }
        public DateTime date { get; set; }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ClassLibrary;

namespace WebApplication1.Pages
{
    public class AddArticleModel : PageModel
    {
        [BindProperty]
        public string Title { get; set; }
        [BindProperty]
        public string Text { get; set; }
        [BindProperty]
        public string Date { get; set; }
        [BindProperty]
        public string Id { get; set; }
        [BindProperty]
        public string Theme { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            Article getArticle = new Article()
            {
                title = Title,
                text = Text,
                date = Date,
                id = Guid.NewGuid().ToString(),
                theme = Theme
            };

            News.WriteArticles(getArticle);

            

            
            return Page();
        }
    }
}
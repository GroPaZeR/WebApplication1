using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


public class OneThemeModel : PageModel
{
    public string Theme {  get; set; }
    public void OnGet(string category)
    {
        Theme = category;
        Console.WriteLine(1);
    }
}

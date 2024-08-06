// Copyright Information
// ==================================
// AutoLot8 - AutoLot.Web - Create.cshtml.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2024/06/29
// ==================================


namespace Demo.Razor.Pages.Cars;

public class CreateModel : PageModel
{
    [ViewData] 
    public string Title { get; init; } = "Create Car";

    [BindProperty] 
    public CarViewModel Entity { get; set; }
    public string Error { get; set; }

    public void OnGet()
    {
        Entity = new CarViewModel { };
    }

    public IActionResult OnPost() => RedirectToPage("./Details", new { id = 1 });
}
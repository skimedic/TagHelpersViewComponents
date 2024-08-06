// Copyright Information
// ==================================
// AutoLot8 - AutoLot.Web - Edit.cshtml.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2024/06/29
// ==================================

using Microsoft.AspNetCore.Mvc.Rendering;

namespace Demo.Razor.Pages.Cars;

public class EditModel(ICarService carService) : PageModel
{
    [ViewData] public string Title { get; init; } = "Edit Car";

    [BindProperty] public CarViewModel Entity { get; set; }
    public string Error { get; set; }

    public void OnGet(int id)
    {
        Entity = carService.GetCar(id);
    }

    public IActionResult OnPost(int id) => RedirectToPage("./Details", new { id = id });

}
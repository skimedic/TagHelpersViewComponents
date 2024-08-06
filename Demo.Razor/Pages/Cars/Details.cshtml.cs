// Copyright Information
// ==================================
// AutoLot8 - AutoLot.Web - Details.cshtml.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2024/06/29
// ==================================

namespace Demo.Razor.Pages.Cars;

public class DetailsModel(ICarService carService) : PageModel
{
        [ViewData] 
    public string Title { get; init; } = "Car Details";

    [BindProperty] 
    public CarViewModel Entity { get; set; }
    public string Error { get; set; }

    public void OnGet(int id) => Entity = carService.GetCar(id);
}
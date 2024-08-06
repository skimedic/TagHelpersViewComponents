// Copyright Information
// ==================================
// AutoLot8 - AutoLot.Web - Index.cshtml.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2024/06/29
// ==================================

namespace Demo.Razor.Pages.Cars;

public class IndexModel(ICarService carService) : PageModel
{
    [ViewData] public string Title { get; init; } = "Cars";

    public string Error { get; set; }

    public IEnumerable<CarViewModel> CarRecords { get; set; }

        public int? MakeId { get; set; }

    public void OnGet(int? makeId)
    {
        if (!makeId.HasValue)
        {
            CarRecords = carService.GetAllCars();
            return;
        }
        MakeId = makeId;
        CarRecords = carService.GetAllCarsFor(makeId.Value);
    }
}
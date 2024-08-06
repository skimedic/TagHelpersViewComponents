// Copyright Information
// ==================================
// AutoLot8 - AutoLot.Web - MenuViewComponent.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2024/06/29
// ==================================

using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace Demo.Razor.ViewComponents;

public class MenuViewComponent(ICarService carService) : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        var makes = carService.GetAllMakes().ToList();
        if (!makes.Any())
        {
            return new ContentViewComponentResult("Unable to get the makes");
        }
        return View("MenuView", makes);
    }

    //public async Task<IViewComponentResult> InvokeAsync()
    //{
    //    var makes = (await carService.GetAllMakesAsync()).ToList();
    //    if (!makes.Any())
    //    {
    //        return new ContentViewComponentResult("Unable to get the makes");
    //    }

    //    return View("MenuView", makes);
    //}
}
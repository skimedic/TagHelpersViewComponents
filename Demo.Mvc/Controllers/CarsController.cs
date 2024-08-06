using Microsoft.AspNetCore.Mvc;

namespace Demo.Mvc.Controllers;

[Route("[controller]/[action]")]
public class CarsController(ICarService carService) : Controller
{
    [Route("/[controller]")]
    [Route("/[controller]/[action]")]
    public IActionResult Index()
    {
        return View(carService.GetAllCars());
    }

    [HttpGet("{makeId}")]
    public IActionResult ByMake(int makeId, string makeName)
    {
        ViewBag.MakeName = makeName;
        return View(carService.GetAllCarsFor(makeId));
    }

    [HttpGet("{id}")]
    public IActionResult Details(int id)
    {
        var entity = carService.GetCar(id);
        return View(entity);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(CarViewModel entity)
    {
        return RedirectToAction(nameof(Details), new { entity.Id });
    }


    [HttpGet("{id}")]
    public IActionResult Edit(int id)
    {
        var entity = carService.GetCar(id);
        return View(entity);
    }

    [HttpPost("{id}")]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int id, CarViewModel entity)
    {
        return RedirectToAction(nameof(Details), new { entity.Id });
    }

    [HttpGet("{id}")]
    public IActionResult Delete(int id)
    {
        var entity = carService.GetCar(id);
        return View(entity);
    }

    [HttpPost("{id}")]
    [ValidateAntiForgeryToken]
    public IActionResult Delete(int id, CarViewModel entity)
    {
        return RedirectToAction(nameof(Index));
    }
}
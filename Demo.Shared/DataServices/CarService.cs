// Copyright Information
// ==================================
// TagHelperViewComponentDemos - Demo.Shared - CarService.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2024/08/05
// ==================================

namespace Demo.Shared.DataServices;

public class CarService : ICarService
{
    List<CarViewModel> _inventory =>
    [
        new() { Id = 1, MakeId = 1, MakeName = "VW", Color = "Black", PetName = "Zippy" },
        new() { Id = 2, MakeId = 2, MakeName = "Ford", Color = "Rust", PetName = "Rusty" },
        new() { Id = 3, MakeId = 3, MakeName = "Saab", Color = "Black", PetName = "Mel" },
        new() { Id = 4, MakeId = 4, MakeName = "Yugo", Color = "Yellow", PetName = "Clunker" },
        new() { Id = 5, MakeId = 5, MakeName = "BMW", Color = "Black", PetName = "Bimmer" },
        new() { Id = 6, MakeId = 5, MakeName = "BMW", Color = "Green", PetName = "Hank" },
        new() { Id = 7, MakeId = 5, MakeName = "BMW", Color = "Pink", PetName = "Pinky" },
        new() { Id = 8, MakeId = 6, MakeName = "Pinto", Color = "Black", PetName = "Pete" },
        new() { Id = 9, MakeId = 4, MakeName = "Yugo", Color = "Brown", PetName = "Brownie" }
    ];

    List<Make> _makes =>
    [
        new() { Id = 1, Name = "VW" },
        new() { Id = 2, Name = "Ford" },
        new() { Id = 3, Name = "Saab" },
        new() { Id = 4, Name = "Yugo" },
        new() { Id = 5, Name = "BMW" },
        new() { Id = 6, Name = "Pinto" }
    ];

    public IQueryable<CarViewModel> GetAllCars()
    {
        return _inventory.AsQueryable();
    }

    public IQueryable<CarViewModel> GetAllCarsFor(int makeId)
    {
        return _inventory.Where(x => x.MakeId == makeId).AsQueryable();
    }

    public CarViewModel GetCar(int id)
    {
        return _inventory.FirstOrDefault(x => x.Id == id);
    }

    public IQueryable<Make> GetAllMakes()
    {
        return _makes.AsQueryable();
    }
}
namespace Demo.Shared.DataServices;

public interface ICarService
{
    IQueryable<CarViewModel> GetAllCars();
    IQueryable<CarViewModel> GetAllCarsFor(int makeId);
    CarViewModel GetCar(int id);
    IQueryable<Make> GetAllMakes();
}
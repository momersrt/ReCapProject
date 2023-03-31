using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI;
class Program
{
    static void Main(string[] args)
    {
        CarManager carManager = new CarManager(new InMemoryCarDal());

        foreach (var car in carManager.GetAll())
        {
            Console.WriteLine("Araba Id: "+car.Id + ", Model Yılı: "+ car.ModelYear + ", Günlük Kiralama: "+car.DailyPrice+", Açıklama: "+ car.Description +", Renk Id: "+car.ColorId);
        }

    }
}
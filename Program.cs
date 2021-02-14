using System;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Business.Concrete;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            ProductManager carMamager = new ProductManager(new InMemoryProductDal());

            foreach(var car in carMamager.GetAll())
            {
                Console.WriteLine(car.Id+" "+car.ModelYear+" "+car.DailyPrice+" "+car.Description);
            }

            Car car1 = new Car { Id = 7, BrandId = 6, ColorId = 6, DailyPrice = 300, ModelYear = 2020, Description = "Lüx Araba" };
            Car car2 = new Car { Id = 4, BrandId = 2, ColorId = 6, DailyPrice = 220, ModelYear = 2018, Description = "Arazi Araba" };
            Car car3 = new Car { Id = 6, BrandId = 2, ColorId = 6, DailyPrice = 220, ModelYear = 2018, Description = "Arazi Araba" };
            carMamager.Add(car1);

                Console.WriteLine("Bir araba eklendi");
            carMamager.Delete(car2); //ID si 4 olan arabayısiler
            carMamager.Update(car3);//ID si 6 olan araba güncellendi
            Console.WriteLine("----Ekleme-Silme-Güncellemeden Sonra Arabalar");
            foreach (var car in carMamager.GetAll())
            {
                Console.WriteLine(car.Id + " " + car.ModelYear + " " + car.DailyPrice + " " + car.Description);
            }
            Console.ReadKey();
        }
    }
}

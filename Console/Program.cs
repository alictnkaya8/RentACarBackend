using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Add(new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 250, ModelYear = "2016", Description = "Renault Clio" });
            Console.WriteLine(carManager.GetAll());
        }
    }
}

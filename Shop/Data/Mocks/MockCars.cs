using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car
                    {
                        name = "Tesla", 
                        shortDesc = "Быстрый автомобиль", 
                        longDesc = "Красивый, быстрый и очень тихий автомобиль компании Tesla",
                        img = "/img/tesla.jpg", 
                        price = 45000,
                        isFavourite = true, 
                        avaliable = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        name = "Ford Fiesta",
                        shortDesc = "Тихий и спокойный",
                        longDesc = "Комфортный автомобиль для городской жизни",
                        img = "/img/Fiesta.jpg",
                        price = 45000,
                        isFavourite = false,
                        avaliable = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "Ford Fiesta",
                        shortDesc = "Тихий и спокойный",
                        longDesc = "Комфортный автомобиль для городской жизни",
                        img = "/img/Fiesta.jpg",
                        price = 45000,
                        isFavourite = false,
                        avaliable = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                    name = "Mercedes C63s AMG w205",
                    shortDesc = "Громкий и быстрый",
                    longDesc = "Твоя зарплата - мне в бак, мои способности -> в твоё счастье",
                    img = "/img/c63amg.jpg",
                    price = 45000,
                    isFavourite = true,
                    avaliable = true,
                    Category = _categoryCars.AllCategories.Last()
                    }
                };
            }
        }

        public IEnumerable<Car> CetFavCars { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}

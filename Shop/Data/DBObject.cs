using System;
using System.Collections.Generic;
using System.Linq;
using Shop.Data.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Shop.Data
{
    public class DBObject
    {
        public static void Initial(AppDBContent content)
        {
            
           
            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c=>c.Value));
            }

            if (!content.Car.Any())
            {
                content.AddRange(new Car
                    {
                        name = "Tesla",
                        shortDesc = "Быстрый автомобиль",
                        longDesc = "Красивый, быстрый и очень тихий автомобиль компании Tesla",
                        img = "/img/tesla.jpg",
                        price = 45000,
                        isFavourite = true,
                        avaliable = true,
                        Category = Categories["Электромобили"]
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
                        Category = Categories["Классические автомобили"]
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
                        Category = Categories["Классические автомобили"]
                    });
            }

            content.SaveChanges();
        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        { 
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category {categoryName = "Электромобили", desc = "Современный вид транспорта"},
                        new Category
                        {
                            categoryName = "Классические автомобили", desc = "Машины с двигателем внутреннего сгорания"
                        }
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category element in list)
                    {
                        category.Add(element.categoryName, element);
                    }
                }

                return category;
            }
        }
    }
}

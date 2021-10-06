using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        private readonly AppDBContent appDBContent;

        public CategoryRepository(AppDBContent appDBcontent)
        {
            this.appDBContent = appDBcontent;
        }
        public IEnumerable<Category> AllCategories => appDBContent.Category;
    }
}

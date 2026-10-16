using GuitarShop.Models;

namespace GuitarShop.ViewModels
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public List<Category> Categories { get; set; } = new List<Category>();

        public string SelectedCategoryName { get; set; } = string.Empty;

        public string CheckActiveCategory(string category)
        {
            return category == SelectedCategoryName ? "active" : "";
        }
    }
}
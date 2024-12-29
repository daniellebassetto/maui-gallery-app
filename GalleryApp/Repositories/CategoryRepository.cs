using GalleryApp.Models;
using GalleryApp.Views.Layouts;

namespace GalleryApp.Repositories;

public class CategoryRepository
{
    public CategoryRepository() { }

    public List<Category> GetCategories()
    {
        List<Category> categories =
        [
            new Category
            {
                Name = "Layout",
                Components = [
                    new Component             {
                        Title = "StackLayout",
                        Description = "Organização sequencial dos elementos.",
                        Page = typeof(StackLayoutPage)
                    }
                ]
            },
        ];

        return categories;
    }
}

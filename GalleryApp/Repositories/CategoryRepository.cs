using GalleryApp.Models;
using GalleryApp.Views.Components.Mains;
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
                    },
                    new Component
                    {
                        Title = "Grid",
                        Description = "Organiza os elementos dentro de uma tabela.",
                        Page = typeof(GridLayoutPage)
                    },
                    new Component
                    {
                        Title = "AbsoluteLayout",
                        Description = "Liberdade total para posicionar os elementos na tela.",
                        Page = typeof(AbsoluteLayoutPage)
                    },
                    new Component
                    {
                        Title = "FlexLayout",
                        Description = "Organiza os elementos de forma sequencial com muitas opções de personalização.",
                        Page = typeof(FlexLayoutPage)
                    }
                ]
            },
            new Category
            {
                Name = "Componentes (Views)",
                Components = [
                    new Component
                    {
                        Title = "BoxView",
                        Description = "Componente que cria uma caixa para ser apresentada",
                        Page = typeof(BoxViewPage)
                    },
                    new Component
                    {
                        Title = "Label",
                        Description = "Apresenta um texto na tela",
                        Page = typeof(LabelPage)
                    }
                ]
            }
        ];

        return categories;
    }
}

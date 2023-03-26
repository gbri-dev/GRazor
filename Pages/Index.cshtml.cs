using Microsoft.AspNetCore.Mvc.RazorPages;
namespace GRazor.Pages;

public class Index : PageModel
{

  public List<Produtos> productsList { get; set; } = new();

  public async Task OnGet()
  {   

    for (int i = 1; i <= 5; i++)
    {
      productsList.Add(
        item: new Produtos(i, Title: $"Produto {i}", Price: i * 295.98M, Image: $"prod{i}.jpg")
      );
    }

  }

}

public record Produtos(
  int Id,
  string Title,
  decimal Price,
  string Image
);
using Microsoft.AspNetCore.Http;

namespace ClickMart.Persistance.Dtos.Media;

public class ImageCreateDto
{
    public IFormFile File { get; set; } = default!;
}
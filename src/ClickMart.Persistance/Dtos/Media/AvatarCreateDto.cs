using Microsoft.AspNetCore.Http;

namespace ClickMart.Persistance.Dtos.Media;

public class AvatarCreateDto
{
    public IFormFile Avatar { get; set; } = default!;
}

using Microsoft.AspNetCore.Identity;

namespace Diente_Fuerte.Models.dbModels
{
    public class ApplicationUser : IdentityUser<int>
    {
        public required string Nombre {  get; set; }

    }
}

using Microsoft.AspNetCore.Identity;

namespace ecom.Models
{
    public class ApplicationUser : IdentityUser
    {
        public List<Shipment>? shipments { get; set; }
        public List<Payment>? payments { get; set; }
        public List<Cart>? carts { get; set; }
        public List<WishList>? wishLists { get; set; }
    }
}

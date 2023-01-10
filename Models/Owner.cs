using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Granota.Models
{
    public class Owner
    {
        [Key]
        public int OwnerId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string? Email { get; set; }
        public int? Phone { get; set; }
        public string? Address { get; set; }

        [Display(Name ="Restaurant")]
        public virtual int? RestaurantId { get; set; }

        [ForeignKey("RestaurantId")]
        public virtual Restaurant? Restaurant { get; set; }

        public Owner(int ownerId, string name, string password, string? email, int? phone, string? address, int? restaurantId)
        {
            OwnerId = ownerId;
            Name = name;
            Password = password;
            Email = email;
            Phone = phone;
            Address = address;
            RestaurantId = restaurantId;
        }

        public Owner() { }
    }
}
